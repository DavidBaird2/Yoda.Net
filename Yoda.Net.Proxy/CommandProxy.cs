using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Yoda.Net.Common;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Encryption;
using Yoda.Net.Networking.Packet;
using Yoda.Net.Networking.Util;
using Yoda.Net.Proxy.Area;
using Yoda.Net.Proxy.Socket;
using Yoda.Net.Proxy.WebSocket;


namespace Yoda.Net.Proxy
{
    public delegate void ConnectedEventHandler(object sender, ConnectedEventArgs e);
    public class CommandProxy
    {
        public event ConnectedEventHandler onLoginClient;
        public List<ProxySession> sessionList;
        public AreaMovementManager moveManager;
        private SocketServer socketProxy;
        private WebSocketServer websocketProxy;
        public CommandProxy()
        {
            sessionList = new List<ProxySession>();
            moveManager = new AreaMovementManager();
        }
        public void init()
        {
            socketProxy = new SocketServer(this);
            socketProxy.Init();
            websocketProxy = new WebSocketServer(this);
            websocketProxy.init();
        }

        public void removeSession(ProxySession session)
        {
            session.InfoProxy = null;
            sessionList.Remove(session);
        }

        public void addSession(ProxySession session)
        {
            sessionList.Add(session);
        }

        public void handleLogin(ProxySession session)
        {
            var arg = new ConnectedEventArgs(session);
            onLoginClient(this, arg);
            if (arg.ForceDissconect)
            {
                session.InfoProxy.Close();
            }
        }
        
        public void handleCommand(CommandFactory facroty, ICommandConnection sender, ICommandBridge brige, Header header, PiggStream array, PiggStream rawPacket)
        {
            try
            {
                array.position = 0;
                ICommandData data = (ICommandData)facroty.getDataClass(header.packetId);
                if (data == null)
                {
                    sender.SendData(rawPacket.toArray());
                    Logger.WriteLine(Common.LogLevel.Attention, "NOTFOUND " +
                        PacketUtil.GetNameFromId(header.packetId, brige.GetServerType()) +
                        " (" + brige.GetServerType().ToString().ToUpper() + ")");
                    return;
                }
                Logger.WriteLine(Common.LogLevel.Attention, data.GetType().Name + 
                    " (" + brige.GetServerType().ToString().ToUpper() + ")");

                if (data is IEncrypted)
                    Des.Decrypt(ref array, brige.EncryptionKey);

                try
                {
                    data.readData(array);
                }
                catch (NotImplementedException)
                {
                    Logger.WriteLine(LogLevel.Infomation, "NotImplementedException : " + 
                        data.GetType().FullName);
                }
                catch (Exception exp)
                {
                    StackTrace trace = new StackTrace(exp, true);
                    Logger.WriteLine(LogLevel.Infomation, "Error read Packet : " + 
                        data.GetType().FullName + " : Num :" + 
                        trace.GetFrame(2).GetFileLineNumber());

                    sender.SendData(rawPacket.toArray());
                    return;
                }
                MethodInfo handler = (MethodInfo)facroty.getHandler(header.packetId);
                if (handler != null)
                {
                    CommandRouteOption option = (CommandRouteOption)handler.Invoke(facroty.GetMessageDelegate(), new object[] { data });
                    switch (option)
                    {
                        case CommandRouteOption.Nothing:
                            sender.SendData(rawPacket.toArray());
                            break;
                        case CommandRouteOption.Edit:
                            sender.SendCommand(data);
                            break;
                        case CommandRouteOption.Block:
                            break;
                    }
                    return;
                }
                sender.SendData(rawPacket.toArray());  //    Can not Found Handler 
            }
            catch (Exception ex)
            {
                Logger.WriteLine(LogLevel.AnalSex, ex.ToString());
            }
        }

    }
}
