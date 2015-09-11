
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Common;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Encryption;
using Yoda.Net.Networking.Packet;
using Yoda.Net.Networking.Util;
using Yoda.Net.Server.Models;

namespace Yoda.Net.Server.Info
{
    public class RemortClient
    {
        public CommandFactory factory;
        public DateTime PingRecivedTime;
        public SocketManager manager;
        public InfoServer server;
        public User user;
        public byte[] secure;

        public RemortClient(InfoServer server, SocketManager manager)
        {
            factory = new CommandFactory(null, ServerType.Info);
            manager.OnRecvPacket += manager_OnRecvPacket;
            manager.OnSocketClosed += manager_OnSocketClosed;

            this.manager = manager;
            server.AddClient(this);
            manager.encId = 0;
            sendHandshake();
            this.server = server;
        }
        public int ConnectionId
        {
            get { return manager.connectionId; }
        }
        public int EncId
        {
            get { return manager.encId; }
        }
        public void Stop()
        {
            manager.StopClient();
        }
        void sendHandshake()
        {
            manager.SendId(ConnectionId);
            manager.SendEnc(EncId);
        }
        void manager_OnSocketClosed()
        {
            server.RemoveClient(this);
        }

        void manager_OnRecvPacket(Header header, PiggStream body, PiggStream rawPacket)
        {
            switch (header.type)
            {
                case SocketManager.TYPE_COMMAND:
                    ICommandData data = (ICommandData)this.factory.getDataClass(header.packetId);

                    if (data == null)
                    {
                        Logger.WriteLine(LogLevel.Attention, "[Emulator] Error: could not find data class id : " + PacketUtil.GetNameFromId(header.packetId, ServerType.Info));
                        break;
                    }

                    Logger.WriteLine(LogLevel.Attention, "[Emulator] onRecvPacket ::  : " + data.GetType().Name);
                    if (data is IEncrypted)
                    {
                        Des.Decrypt(ref body, manager.GetEncryptionKey());
                    }
                    data.readData(body);

                    MethodInfo handler = (MethodInfo)factory.getHandler(header.packetId);
                    if (handler != null)
                    {
                        var option = handler.Invoke(this.factory.GetMessageDelegate(), new object[] { data, this });
                        return;
                    }


                    break;
                case SocketManager.TYPE_PING:
                    manager.SendPing();
                    PingRecivedTime = DateTime.Now;
                    break;


            }
        }
    }
}
