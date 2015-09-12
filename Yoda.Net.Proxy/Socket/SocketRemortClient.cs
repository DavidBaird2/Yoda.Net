
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Networking;

namespace Yoda.Net.Proxy.Socket
{
    public class SocketRemortClient : ICommandConnection
    {
        private SocketBrige socketBrige;
        protected IMessageHandler handler;
        protected SocketManager manager;
        protected CommandFactory factory;
        public System.Net.Sockets.Socket socket;

        public SocketRemortClient(SocketBrige socketBrige)
        {
            this.socketBrige = socketBrige;
            manager = new SocketManager();
            manager.OnSocketClosed += manager_OnSocketClosed;
            manager.OnRecvPacket += manager_OnRecvPacket;
        }

        void manager_OnRecvPacket(Header header, PiggStream body, PiggStream rawPacket)
        {
            switch (header.type)
            {
                case SocketManager.TYPE_COMMAND:
                    socketBrige.HandleClientCommand(factory,header, body, rawPacket);
                    break;
                case SocketManager.TYPE_ID:
                    socketBrige.SendDataToServer(rawPacket.toArray());
                    break;
                case SocketManager.TYPE_PING:
                    //   Logger.WriteLine(Common.LogLevel.Attention, "Recv Ping From Client IsInfo:" + type.ToString());
                    socketBrige.SendDataToServer(rawPacket.toArray());
                    break;
                case SocketManager.TYPE_ENC:
                    
                    socketBrige.SendDataToServer(rawPacket.toArray());
                    break;

            }
        }

        void manager_OnSocketClosed()
        {
            socketBrige.HandleClientClosed();
        }

   
        public void SendCommand(Networking.Packet.ICommandData data)
        {
            manager.SendCommand(data);
        }

        public void SendData(byte[] data)
        {
            manager.SendData(data);
        }

        public void SetMessageHandler(Networking.IMessageHandler handler)
        {
            factory = new CommandFactory(handler, socketBrige.GetServerType());
            this.handler = handler;
        }


        public void Close()
        {
            manager.Dissconect();
        }

        public Networking.CommandFactory GetFactory()
        {
            return factory;
        }




        public void Open()
        {
            manager.SetSocket(socket);
        }
    }

}
