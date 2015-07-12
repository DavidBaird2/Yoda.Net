using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Proxy;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

         //   Yoda.Net.Common.CodeDomTest.CreateTest();
            var policySever = new Yoda.Net.Networking.PolicyServer();
            policySever.init();


            var session = new ProxySession();

            session.InfoClientHandler = new InfoClientHandler(session);
            session.ChatClientHandler = new ChatClientHandler(session);

            session.InfoServerHandler = new InfoServerHandler(session);
            session.ChatServerHandler = new ChatServerHandler(session);

            var manager = new CommandProxyManager();
            manager.session = session;
            manager.init();
            var IEVAlue = 9000; // can be: 9999 , 9000, 8888, 8000, 7000

           Console.ReadLine();
        }
    }
}
