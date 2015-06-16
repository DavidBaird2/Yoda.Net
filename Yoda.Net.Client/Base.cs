using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Packet;

namespace Yoda.Net.Client
{
    public class CommandClient
    {
        protected NetworkManager manager;
        protected CommandFactory factory;

        public CommandClient(IMessageDelegate del, ServerType type)
        {
            manager = new NetworkManager(del);
            manager.OnRecvPacket += manager_OnRecvPacket;


            factory = new CommandFactory(del, type);
        }


        void manager_OnRecvPacket(Header header, AmebaStream array, AmebaStream rawPacket)
        {
            switch (header.type)
            {
                case NetworkManager.TYPE_COMMAND:
                    IPacket data = (IPacket)this.factory.getDataClass(header.packetId);

                    if (data == null)
                    {
                        break;
                    }

                    data.readData(array);

                    MethodInfo handler = (MethodInfo)factory.getHandler(header.packetId);
                    if (handler != null)
                    {
                        var option = handler.Invoke(this.factory.GetMessageDelegate(), new object[] { data });
                        return;
                    }


                    break;
                case NetworkManager.TYPE_ID:
                    break;
                case NetworkManager.TYPE_PING:
                    manager.connectionId = header.callId;
                    break;
                case NetworkManager.TYPE_ENC:
                    onReady();
                    break;

            }
        }

        public virtual void onReady()
        {

        }
        public void Connect(string host ,int port)
        {
            manager.Connect(host, port);
        }

        
    }
}
