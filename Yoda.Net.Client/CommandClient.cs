using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Common;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Packet;
using Yoda.Net.Networking.Util;

namespace Yoda.Net.Client
{
    public class CommandClient
    {
        protected SocketManager manager;
        protected CommandFactory factory;
        protected IMessageHandler handler;
        public CommandClient(ServerType type)
        {
            manager = new SocketManager();
            manager.OnRecvPacket += manager_OnRecvPacket;

            serverType = type;

        }
        public void SetMessageHandler(IMessageHandler handler)
        {
            this.handler = handler;

            this.factory = new CommandFactory(handler, serverType);

        }

        void manager_OnRecvPacket(Header header, PiggStream array, PiggStream rawPacket)
        {
            switch (header.type)
            {
                case SocketManager.TYPE_COMMAND:
                    ICommandData data = this.factory.getDataClass(header.packetId);
                    if (data == null)
                    {
                        Logger.WriteLine(Common.LogLevel.Attention, "[BOT] Error: could not find data class id : " + PacketUtil.GetNameFromId(header.packetId, serverType));
                        break;
                    }

                    Logger.WriteLine(Common.LogLevel.Attention, "[BOT] onRecvPacket :: " + serverType.ToString() + " : " + data.GetType().Name);
                    data.readData(array);

                    MethodInfo handler = factory.getHandler(header.packetId);
                    if (handler != null)
                    {
                        var option = handler.Invoke(this.factory.GetMessageDelegate(), new object[] { data });
                        return;
                    }


                    break;
                case SocketManager.TYPE_ID:
                    manager.connectionId = header.callId;
                    break;
                case SocketManager.TYPE_PING:
              
                    break;
                case SocketManager.TYPE_ENC:
                    manager.encId = header.callId;
                    onReady();
                    break;

            }
        }

        public void SendCommand(ICommandData data)
        {
            Logger.WriteLine(Common.LogLevel.Attention, "[BOT] SendCommand :: " + serverType.ToString() + " : " + data.GetType().Name);
            manager.SendCommand(data);
        }
        public virtual void onReady()
        {

        }
        public void Connect(string host ,int port)
        {
            manager.Connect(host, port);
        }



        public ServerType serverType { get; set; }
    }
}
