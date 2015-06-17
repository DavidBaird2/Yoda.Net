using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


using System.Reflection;
using Yoda.Net.Networking.Packet;
using Yoda.Net.Networking.Packet.Info.Area;
using System.Diagnostics;
using System.Threading;
using Yoda.Net.Networking;
using DNS.Client;
using Yoda.Net.Networking.Encryption;
using Yoda.Net.Common;

namespace Yoda.Net.Proxy
{
    public class CommandProxy
    {
        private NetworkManager clientNetworkManager;
        private NetworkManager serverNetworkManager;
        private CommandProxyManager manager;
        private ProxySession session;
        private IMessageDelegate clientDelegate;
        private IMessageDelegate serverDelegate;
        private CommandFactory clientfactory;
        private CommandFactory serverfactory;
        private int _connectionId;
        public ServerType type;
        private static string PIGG_INFO_SERVER_ADDR = "180.233.143.102";//info.pigg.ameba.jp
        private static int PIGG_INFO_SERVER_PORT = 1935;
        public CommandProxy(ProxySession session, CommandProxyManager manager, ServerType type)
        {
            if(type == ServerType.Info)
            {
                this.clientDelegate = session.InfoClientHandler;
                this.serverDelegate = session.InfoServerHandler;
            }

            if (type == ServerType.Chat)
            {
                this.clientDelegate = session.ChatClientHandler;
                this.serverDelegate = session.ChatServerHandler;
            }

            this.session = session;
            clientfactory = new CommandFactory(clientDelegate, type);
            serverfactory = new CommandFactory(serverDelegate, type);

            this.type = type;
            this.manager = manager;
        }

        public void Start(Socket clientSocket)
        {
            clientNetworkManager = new NetworkManager(clientDelegate);
            clientNetworkManager.OnRecvPacket += onRecvPacketFromClient;
            clientNetworkManager.OnSocketClosed += onClientSocketClosed;

            serverNetworkManager = new NetworkManager(serverDelegate);
            serverNetworkManager.OnRecvPacket += onRecvPacketFromServer;
            serverNetworkManager.OnSocketClosed += onServerSocketClosed;

            if (type == ServerType.Info)
                serverNetworkManager.Connect(PIGG_INFO_SERVER_ADDR, PIGG_INFO_SERVER_PORT);

            if (type == ServerType.Chat)
                serverNetworkManager.Connect(Yoda.Net.Common.DNS.ResolveDNS(session.LastGetAreaServer), PIGG_INFO_SERVER_PORT);

            clientNetworkManager.SetSocket(clientSocket);
        }

        void onClientSocketClosed()
        {
            if (serverNetworkManager.Connected)
                serverNetworkManager.StopClient();
            manager.removeProxy(this);
        }
        void onServerSocketClosed()
        {
            if (clientNetworkManager.Connected)
                clientNetworkManager.StopClient();
            manager.removeProxy(this);
        }
        private void onRecvPacketFromServer(Header header, AmebaStream array, AmebaStream rawPacket)
        {

           Yoda.Net.Common.Logger.Log(Common.LogLevel.Attention,"onRecvPacketFromServer ::" + type.ToString() + header.length + " : " + array.position);
            switch (header.type)
            {
                case NetworkManager.TYPE_COMMAND:
                    IPacket data = (IPacket)this.serverfactory.getDataClass(header.packetId);

                    if (data == null)
                    {
                        clientNetworkManager.SendData(rawPacket.toArray());
                        break;
                        // cannot found data Class
                    }
                    try
                    {
                        data.readData(array);
                    }
                    catch(Exception ex)
                    {
                        //Error Read Data 
                       Logger.Log(LogLevel.Infomation,"Error read Packet : "+data.GetType().FullName);
                       Logger.Log(LogLevel.Infomation, ex.ToString());
                        clientNetworkManager.SendData(rawPacket.toArray());
                        break;
                    }

                    MethodInfo handler = (MethodInfo)serverfactory.getHandler(header.packetId);
                    if (handler != null)
                    {
                        CommandRouteOption option = (CommandRouteOption)handler.Invoke(this.serverfactory.GetMessageDelegate(), new object[] { data });
                        switch (option)
                        {
                            case CommandRouteOption.Nothing:
                                clientNetworkManager.SendData(rawPacket.toArray());
                                break;
                            case CommandRouteOption.Edit:
                                clientNetworkManager.SendCommand(data);
                                break;
                            case CommandRouteOption.Block:
                                break;
                        }
                        return;
                    }

                    clientNetworkManager.SendData(rawPacket.toArray());
                    //    Can not Found Handler 
                    break;

                case NetworkManager.TYPE_ID:

                    clientNetworkManager.connectionId = header.callId;
                    serverNetworkManager.connectionId = header.callId;
                    clientNetworkManager.SendData(rawPacket.toArray());
                    break;
                case NetworkManager.TYPE_PING:
                   Logger.Log(Common.LogLevel.Attention, "Recv Ping From Server IsInfo:" + type.ToString());
                    clientNetworkManager.SendData(rawPacket.toArray());
                    break;
                case NetworkManager.TYPE_ENC:


                    clientNetworkManager.encId = header.callId;
                    serverNetworkManager.encId = header.callId;
                    clientNetworkManager.SendData(rawPacket.toArray());
                    break;

            }

        }


        private void onRecvPacketFromClient(Header header, AmebaStream array, AmebaStream rawPacket)
        {

            Logger.Log(Common.LogLevel.Attention, "onRecvPacketFromClient ::" + type.ToString());
            switch (header.type)
            {
                case NetworkManager.TYPE_COMMAND:
                    IPacket data = (IPacket)this.clientfactory.getDataClass(header.packetId);

                    if (data == null)
                    {
                        serverNetworkManager.SendData(rawPacket.toArray());
                        break;  // cannot found data Class
                    }
                    if (data is IEncrypted)
                    {
                        Des.decrypt(out array, array, clientNetworkManager.getEncryptionKey());
                        //decrypt Array
                    }

                    data.readData(array);


                    MethodInfo handler = (MethodInfo)clientfactory.getHandler(header.packetId);
                    if (handler != null)
                    {
                        CommandRouteOption option = (CommandRouteOption)handler.Invoke(clientfactory.GetMessageDelegate(), new object[] { data });
                        switch (option)
                        {
                            case CommandRouteOption.Nothing:
                                serverNetworkManager.SendData(rawPacket.toArray());
                                break;
                            case CommandRouteOption.Edit:
                                serverNetworkManager.SendCommand(data);
                                break;
                            case CommandRouteOption.Block:
                                break;
                        }
                        return;
                    }

                    serverNetworkManager.SendData(rawPacket.toArray());
                    //    Can not Found Handler 

                    break;
                case NetworkManager.TYPE_ID:
                    serverNetworkManager.SendData(rawPacket.toArray());
                    break;
                case NetworkManager.TYPE_PING:
                    Logger.Log(Common.LogLevel.Attention, "Recv Ping From Client IsInfo:" + type.ToString());
                    serverNetworkManager.SendData(rawPacket.toArray());
                    break;
                case NetworkManager.TYPE_ENC:
                    serverNetworkManager.SendData(rawPacket.toArray());
                    break;

            }



        }



        private void Stop()
        {

        }
    }
}
