
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Encryption;
using Yoda.Net.Networking.Packet;

namespace Yoda.Net.Proxy.WebSocket
{
    public class WebSocketClient : ICommandConnection
    {
        private WebSocketBrige brige;
        private CommandFactory factory;
        private WebSocket4Net.WebSocket socket;
        public WebSocketClient(WebSocketBrige webSocketBrige)
        {
            
            this.brige = webSocketBrige;


            ServicePointManager.ServerCertificateValidationCallback =
            new RemoteCertificateValidationCallback(
              OnRemoteCertificateValidationCallback);
        }

        private bool OnRemoteCertificateValidationCallback(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        void socket_Closed(object sender, EventArgs e)
        {
            brige.HandleServerClosed();
        }

        void socket_DataReceived(object sender, WebSocket4Net.DataReceivedEventArgs e)
        {
            byte[] data = e.Data;
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
                brige.RouteDataFromServer(data);
                //ready
            }
            else if (type == SocketManager.TYPE_PING)
            {
                brige.RouteDataFromServer(data);
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
              //  brige.RouteDataFromServer(data);
               brige.HandleServerCommand(factory, header, content, stream);
            }
        }

        void socket_Error(object sender, SuperSocket.ClientEngine.ErrorEventArgs e)
        {
            
        }

        void socket_Opened(object sender, EventArgs e)
        {
            
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
            socket.Send(data, 0, data.Length);
        }

        public void SetMessageHandler(Networking.IMessageHandler handler)
        {
            factory = new CommandFactory(handler, brige.GetServerType());
        }

        public void Close()
        {
            socket.Close();
        }

        public void Open()
        {
         //   Uri uri = new Uri(brige.TargetHost);
            //string resolve = Common.DNS.ResolveDNS(uri.Host);
           // string ovverideHost = brige.TargetHost.Replace(uri.Host, resolve);

            socket = new WebSocket4Net.WebSocket(brige.TargetHost, null, null, null, null, "http://pigg.ameba.jp", WebSocket4Net.WebSocketVersion.Rfc6455,null);
            socket.Opened += socket_Opened;
            socket.AllowUnstrustedCertificate = true;
            socket.Error += socket_Error;
            socket.DataReceived += socket_DataReceived;
            socket.Closed += socket_Closed;
            
            socket.Open();
        }

        public Networking.CommandFactory GetFactory()
        {
            return factory;
        }
    }
}
