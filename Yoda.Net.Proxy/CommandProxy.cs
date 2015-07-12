using System;
using System.Net.Sockets;

using System.Reflection;
using Yoda.Net.Networking.Packet;
using System.Diagnostics;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Encryption;
using Yoda.Net.Common;

namespace Yoda.Net.Proxy
{
    public class CommandProxyTest
    {
        private NetworkManager clientNetworkManager;
        private NetworkManager serverNetworkManager;
        private CommandProxyManager manager;
        private ProxySession session;
        private IMessageHandler clientDelegate;
        private IMessageHandler serverDelegate;
        private CommandFactory clientfactory;
        private CommandFactory serverfactory;
        private static string PIGG_INFO_SERVER_ADDR = "180.233.143.102";
        private static int PIGG_INFO_SERVER_PORT = 1935;
        public ServerType type;
        public CommandProxyTest(ProxySession session, CommandProxyManager manager, ServerType type)
        {
            this.session = session;
            this.manager = manager;
            this.type = type;
            this.init();
        }

        private void init()
        {
            if (type == ServerType.Info)
            {
                this.clientDelegate = session.InfoClientHandler;
                this.serverDelegate = session.InfoServerHandler;
            }
            else if (type == ServerType.Chat)
            {
                this.clientDelegate = session.ChatClientHandler;
                this.serverDelegate = session.ChatServerHandler;
            }

            clientfactory = new CommandFactory(clientDelegate, type);
            serverfactory = new CommandFactory(serverDelegate, type);

            clientNetworkManager = new NetworkManager(clientDelegate);

            clientNetworkManager.OnRecvPacket += onRecvPacketFromClient;
            clientNetworkManager.OnSocketClosed += onClientSocketClosed;

            serverNetworkManager = new NetworkManager(serverDelegate);

            serverNetworkManager.OnRecvPacket += onRecvPacketFromServer;
            serverNetworkManager.OnSocketClosed += onServerSocketClosed;
        }
        public void Start(Socket clientSocket)
        {

            if (type == ServerType.Info)
                serverNetworkManager.Connect(PIGG_INFO_SERVER_ADDR, PIGG_INFO_SERVER_PORT);

            if (type == ServerType.Chat)
                serverNetworkManager.Connect(Yoda.Net.Common.DNS.ResolveDNS(session.LastGetAreaServer), PIGG_INFO_SERVER_PORT);

            clientNetworkManager.SetSocket(clientSocket);
        }


        private void onServerSocketClosed()
        {
            clientNetworkManager.StopClient();
            manager.removeProxy(this);
        }
        public void SendMessageToServer(ICommandData packet)
        {
            this.serverNetworkManager.SendCommand(packet);
        }


        private void onClientSocketClosed()
        {
            serverNetworkManager.StopClient();

            manager.removeProxy(this);
        }
        public void SendMessageToClient(ICommandData packet)
        {
            this.clientNetworkManager.SendCommand(packet);
        }


        private void onRecvPacketFromServer(Header header, PiggStream array, PiggStream rawPacket)
        {

            Yoda.Net.Common.Logger.Log(Common.LogLevel.Attention, "onRecvPacketFromServer : " + type.ToString());
            switch (header.type)
            {
                case NetworkManager.TYPE_COMMAND:
                    ProcessCommand(serverfactory, clientNetworkManager, header, array, rawPacket);
                    break;
                case NetworkManager.TYPE_ID:
                    clientNetworkManager.connectionId = header.callId;
                    serverNetworkManager.connectionId = header.callId;
                    clientNetworkManager.SendData(rawPacket.toArray());
                    break;
                case NetworkManager.TYPE_PING:
                    Logger.Log(Common.LogLevel.Attention, "Recv Ping From " + type.ToString() + "Server");
                    clientNetworkManager.SendData(rawPacket.toArray());
                    break;
                case NetworkManager.TYPE_ENC:
                    clientNetworkManager.encId = header.callId;
                    serverNetworkManager.encId = header.callId;
                    clientNetworkManager.SendData(rawPacket.toArray());
                    break;

            }

        }

        private void onRecvPacketFromClient(Header header, PiggStream array, PiggStream rawPacket)
        {
            switch (header.type)
            {
                case NetworkManager.TYPE_COMMAND:
                    ProcessCommand(clientfactory, serverNetworkManager, header, array, rawPacket);
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


        private void ProcessCommand(CommandFactory facroty, NetworkManager manager, Header header, PiggStream array, PiggStream rawPacket)
        {
            try
            {
                ICommandData data = (ICommandData)facroty.getDataClass(header.packetId);

                Logger.Log(Common.LogLevel.Attention, "onRecvPacket :: " + type.ToString());

                if (data == null)
                {
                    manager.SendData(rawPacket.toArray());
                    Logger.Log(Common.LogLevel.Attention, " Error: could not find data class id : " + header.packetId);
                    return;
                }
                Logger.Log(Common.LogLevel.Attention, data.GetType().FullName);

                if (data is IEncrypted)
                {
                    Des.decrypt(ref array, clientNetworkManager.getEncryptionKey());
                }
                try
                {
                    data.readData(array);
                }
                catch (NotImplementedException)
                {
                    Logger.Log(LogLevel.Infomation, "NotImplementedException : " + data.GetType().FullName);
                }
                catch (Exception exp)
                {

                    StackTrace trace = new StackTrace(exp, true);

                    Logger.Log(LogLevel.Infomation, "Error read Packet : " + data.GetType().FullName + " : Num :" + trace.GetFrame(2).GetFileLineNumber());
                    manager.SendData(rawPacket.toArray());
                    return;
                }

                MethodInfo handler = (MethodInfo)facroty.getHandler(header.packetId);
                if (handler != null)
                {
                    CommandRoute option = (CommandRoute)handler.Invoke(facroty.GetMessageDelegate(), new object[] { data });
                    switch (option)
                    {
                        case CommandRoute.Nothing:
                            manager.SendData(rawPacket.toArray());
                            break;
                        case CommandRoute.Edit:
                            manager.SendCommand(data);
                            break;
                        case CommandRoute.Block:
                            break;
                    }
                    return;
                }
                manager.SendData(rawPacket.toArray());  //    Can not Found Handler 
            }catch(Exception ex )
            {
                Logger.Log(LogLevel.Sex, ex.ToString());
            }
        }

    }
}
