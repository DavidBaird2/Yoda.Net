using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Networking;
using Yoda.Net.Proxy.Socket;

namespace Yoda.Net.Proxy.Socket
{
    public class SocketServer
    {
        private TcpListener tcpListener;
        private CommandProxy commandProxy;

        public SocketServer(CommandProxy commandProxy)
        {
            this.commandProxy = commandProxy;
        }

        public void Init()
        {
            tcpListener = new TcpListener(IPAddress.Any, 1935);
            tcpListener.Start();
            tcpListener.BeginAcceptTcpClient(new AsyncCallback(onConnected), tcpListener);
            StartAccept();
        }

        public CommandProxy GetManager()
        {
            return commandProxy;
        }

        private void onConnected(IAsyncResult ar)
        {
            TcpListener asyncState = (TcpListener)ar.AsyncState;
            System.Net.Sockets.Socket clientSocket = asyncState.EndAcceptSocket(ar);

            
            //全セッションのうちエリア移動中のものがなければInfo
            var session = new ProxySession(commandProxy);
            SocketBrige proxy = null;
            var move = commandProxy.moveManager.Dequeue();
            if (move == null)
            {
                proxy = new SocketBrige(session, this, ServerType.Info);
                proxy.SetClientHandler(session.InfoClientHandler);
                proxy.SetServerHandler(session.InfoServerHandler);
                proxy.TargetHost = "info.pigg.ameba.jp:1935";
                session.InfoProxy = proxy;
            }
            else
            {
                session = move.session;
                proxy = new SocketBrige(session, this, ServerType.Chat);
                proxy.SetClientHandler(session.ChatClientHandler);
                proxy.SetServerHandler(session.ChatServerHandler);
                proxy.TargetHost = move.server;
          
                session.ChatProxy= proxy; //仮にリストで扱う！
            }

            proxy.Start(clientSocket);
         
            StartAccept();
        }

        private void StartAccept()
        {
            tcpListener.BeginAcceptTcpClient(new AsyncCallback(onConnected), tcpListener);
        }

    }
}
