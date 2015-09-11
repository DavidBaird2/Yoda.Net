using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Networking;

namespace Yoda.Net.Proxy.Socket
{
    public class SocketClient : ICommandConnection
    {
        protected SocketManager manager;
        protected CommandFactory factory;
        protected IMessageHandler handler;
        protected ProxyBridge brige;


        public SocketClient(ProxyBridge brige)
        {
            manager = new SocketManager();
            manager.OnRecvPacket += manager_OnRecvPacket;
            manager.OnSocketClosed += manager_OnSocketClosed;
            this.brige = brige;
        }

        void manager_OnSocketClosed()
        {
            brige.HandleServerClosed();
        }

        private void manager_OnRecvPacket(Header header, PiggStream body, PiggStream rawPacket)
        {

            switch (header.type)
            {
                case SocketManager.TYPE_COMMAND:
                    brige.HandleServerCommand(factory,header, body, rawPacket);
                    break;
                case SocketManager.TYPE_ID:
                    brige.ConnectionId = header.callId;

                    brige.SendDataToClient(rawPacket.toArray());
                    break;
                case SocketManager.TYPE_PING:

                    brige.SendDataToClient(rawPacket.toArray());
                    break;
                case SocketManager.TYPE_ENC:
                    var encId = header.callId;
                    PiggStream stream = new PiggStream();
                    stream.writeInt(encId);
                    stream.writeInt(brige.ConnectionId);
                    brige.EncryptionKey = stream.toArray();
                    brige.SendDataToClient(rawPacket.toArray());
                    break;

            }


        }

        public void SetMessageHandler(IMessageHandler handler)
        {
            this.handler = handler;

            this.factory = new CommandFactory(handler, brige.GetServerType());

        }


        public void SendCommand(Networking.Packet.ICommandData data)
        {
            manager.SendCommand(data);
        }

        public void SendData(byte[] data)
        {
            manager.SendData(data);
        }


        public void Close()
        {
            manager.Dissconect();
        }

        public void Open()
        {
            string[] adress = brige.TargetHost.Split(':');
            //hosts回避のためにホスト名からIPアドレスをlookup
            string resolve = Common.DNS.ResolveDNS(adress[0]);

            manager.Connect(resolve, Convert.ToInt32(adress[1]));
        }

        public CommandFactory GetFactory()
        {
            return this.factory;
        }
    }
}
