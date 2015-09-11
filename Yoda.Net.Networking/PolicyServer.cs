using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking
{
    public class PolicyServer
    {
        private TcpListener tcpListener;
        public void init()
        {
           tcpListener = new TcpListener(IPAddress.Any, 843);
            tcpListener.Start();
            StartAccept();
        }

        private void NewClientHandler(IAsyncResult ar)
        {
            StartAccept();
            TcpListener asyncState = (TcpListener)ar.AsyncState;
            Socket clientSocket = asyncState.EndAcceptSocket(ar);
            clientSocket.Send(System.Text.Encoding.UTF8.GetBytes("<?xml version=\"1.0\"?>\r\n" +
                        "<!DOCTYPE cross-domain-policy SYSTEM \"/xml/dtds/cross-domain-policy.dtd\">\r\n" +
                        "<cross-domain-policy>\r\n" +
                        "<allow-access-from domain=\"*\" to-ports=\"*\" />\r\n" +
                        "</cross-domain-policy>\x0"));
            
          
        }
        private void StartAccept()
        {
            tcpListener.BeginAcceptTcpClient(new AsyncCallback(NewClientHandler), tcpListener);
        }

    }
}
