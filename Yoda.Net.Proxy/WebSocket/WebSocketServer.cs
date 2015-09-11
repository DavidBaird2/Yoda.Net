using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Networking;
using Yoda.Net.Proxy.WebSocket;

namespace Yoda.Net.Proxy.WebSocket
{
    public class WebSocketServer
    {
        private CommandProxy commandProxyManager;
        List<WebSocketBrige> brigeList = new List<WebSocketBrige>();
        public WebSocketServer(CommandProxy commandProxyManager)
        {
            this.commandProxyManager = commandProxyManager;
        }
        public void init()
        {
            var rootConfig = new SuperSocket.SocketBase.Config.RootConfig();
          
            var serverConfig = new SuperSocket.SocketBase.Config.ServerConfig()
            {
                Port = 443,
                Ip = "127.0.0.1",
                Security = "tls",
                MaxConnectionNumber = 100,
                Mode = SuperSocket.SocketBase.SocketMode.Tcp,
                Certificate = new SuperSocket.SocketBase.Config.CertificateConfig
                {
                    FilePath = @"localhost.pfx",
                    Password = "supersocket",
                    ClientCertificateRequired = false
                }
              
            };
            
            var server = new SuperWebSocket.WebSocketServer();
            server.Setup(rootConfig, serverConfig);

            server.NewSessionConnected += server_NewSessionConnected;
            server.NewDataReceived += server_NewDataReceived;
            server.SessionClosed += server_SessionClosed;
  
            server.Start();
        }

        void server_NewDataReceived(SuperWebSocket.WebSocketSession session, byte[] value)
        {
            var target = brigeList.Where(i => i.Session == session).Single();
            target.remortClient.ReadMessage(value);
        }


        private void server_SessionClosed(SuperWebSocket.WebSocketSession session, SuperSocket.SocketBase.CloseReason value)
        {
            var target = brigeList.RemoveAll(i => i.Session == session);
       
        }

        private void server_NewSessionConnected(SuperWebSocket.WebSocketSession wss)
        {


            //全セッションのうちエリア移動中のものがなければInfo
            var session = new ProxySession(commandProxyManager);
            WebSocketBrige proxy = null;
            var move = commandProxyManager.moveManager.Dequeue();
            if (move == null)
            {
               proxy = new WebSocketBrige(session, this, ServerType.Info);
                proxy.TargetHost = "wss://pigg.ameba.jp:443/command";
                proxy.SetClientHandler(session.InfoClientHandler);
                proxy.SetServerHandler(session.InfoServerHandler);
                session.InfoProxy = proxy;
            }
            else
            {
                session = move.session;
                proxy = new WebSocketBrige(session, this, ServerType.Chat);
                proxy.SetClientHandler(session.ChatClientHandler);
                proxy.SetServerHandler(session.ChatServerHandler);
                proxy.TargetHost = move.server;

                session.ChatProxy = proxy;
            }
            brigeList.Add(proxy);
            proxy.Start(wss);
        }

        internal CommandProxy getManager()
        {
           return  commandProxyManager;
        }
    }

}
