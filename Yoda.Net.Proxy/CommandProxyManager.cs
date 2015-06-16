using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Networking;

namespace Yoda.Net.Proxy
{
    public class CommandProxyManager
    {
        private List<CommandProxy> sockets;
        private TcpListener tcpListener;
        public ProxySession session;

        public void init()
        {
            sockets = new List<CommandProxy>();

            tcpListener = new TcpListener(IPAddress.Any, 1935);
            tcpListener.Start();
            tcpListener.BeginAcceptTcpClient(new AsyncCallback(NewConnection), tcpListener); StartAccept();
        }



        private void NewConnection(IAsyncResult ar)
        {
            StartAccept();

            TcpListener asyncState = (TcpListener)ar.AsyncState;
            Socket clientSocket = asyncState.EndAcceptSocket(ar);

            if (clientSocket == null)
            {
                return;
            }

            if (session.InfoProxy == null)
            {
                session.InfoProxy = new CommandProxy(session, this, ServerType.Info);
                session.InfoProxy.Start(clientSocket);
                return;

            }

            var chatProxy = new CommandProxy(session, this, ServerType.Chat);

            session.ChatProxy.Add(chatProxy);

            chatProxy.Start(clientSocket);

        }
        private void StartAccept()
        {
            tcpListener.BeginAcceptTcpClient(new AsyncCallback(NewConnection), tcpListener);
        }

        public void removeProxy(CommandProxy proxy)
        {
            if (proxy.type == ServerType.Info)
            {
                session.InfoProxy = null;

                return;
            }
            session.ChatProxy.Remove(proxy);

        }


    }
}
