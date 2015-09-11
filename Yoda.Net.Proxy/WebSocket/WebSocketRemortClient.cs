using SuperWebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Encryption;
using Yoda.Net.Networking.Packet;

namespace Yoda.Net.Proxy.WebSocket
{
    public class WebSocketRemortClient : ICommandConnection
    {
        ICommandBridge brige;
        CommandFactory factory;
        WebSocketSession wsSession;
        public WebSocketRemortClient(ICommandBridge brige)
        {
            this.brige = brige;

        }
        public void SendCommand(Networking.Packet.ICommandData data)
        {

            var stream = new PiggStream();
            stream.writeShort(SocketManager.TYPE_COMMAND);
            stream.writeInt(0);
            stream.position = 11;
            stream.writeByte(0);

            var buffer = new PiggStream();
            if (data is IEncrypted)
            {

                data.writeData(buffer);
                if (data is IncludeClientTime)
                {
                    buffer.writeDate(DateTime.Now);
                }
                buffer.position = 0;
                Des.Encrypt(ref buffer, brige.EncryptionKey);
                stream.writeBytes(buffer.toArray());
            }
            else
            {
                data.writeData(stream);
                if (data is IncludeClientTime)
                {
                    buffer.writeDate(DateTime.Now);
                }
            }
            stream.position = 6;
            stream.writeShort((short)data.packetId);
            stream.writeInt(((int)stream.length - 12));
            stream.position = 0;
            this.SendData(stream.toArray());
        }

        public void SendData(byte[] data)
        {
            wsSession.Send(data, 0, data.Length);
        }
        public void SetWebProxySession(WebSocketSession session)
        {
            wsSession = session;
        }
        public void ReadMessage(byte[] data)
        {
            PiggStream stream = new PiggStream(data);
            int type = stream.readShort();
            if (type == SocketManager.TYPE_ID)
            {
                var id = stream.readInt(); //connectionID
                var key = stream.readInt();//Encrypte key

                brige.ConnectionId = id;
                var keyArray = new PiggStream();
                keyArray.writeInt(key);
                keyArray.writeInt(brige.ConnectionId);
                keyArray.position = 0;
                brige.EncryptionKey = keyArray.toArray();
                brige.RouteDataFromClient(data);
                //ready
            }
            else if (type == SocketManager.TYPE_PING)
            {
                brige.RouteDataFromClient(data);
            }
            else if (type == SocketManager.TYPE_COMMAND)
            {
                var callId = stream.readInt();
                var commandId = stream.readShort();
                var length = stream.readInt();
                var content = new PiggStream();


                content.writeBytes(stream.readBytes(length));

                var header = new Header();
                header.type = (short)type;
                header.packetId = commandId;
                header.length = length;
                header.callId = callId;
              //  brige.RouteDataFromClient(data);
                brige.HandleClientCommand(factory,header, content, stream);
            }
        }


        public void SetMessageHandler(IMessageHandler handler)
        {
            factory = new CommandFactory(handler, brige.GetServerType());

        }


        public void Close()
        {
            brige.HandleClientClosed();
        }

        public void Open()
        {

        }

        public CommandFactory GetFactory()
        {
            return factory;
        }
    }
}
