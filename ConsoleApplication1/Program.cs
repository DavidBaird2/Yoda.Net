using System;
using System.Collections.Generic;
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

            var policySever = new Yoda.Net.Networking.PolicyServer();
            policySever.init();
            var session = new ProxySession();
            session.InfoClientHandler = new InfoClientHandler();
            session.ChatClientHandler = new ChatClientHandler();
            session.InfoServerHandler = new InfoServerHandler(session);
            session.ChatServerHandler = new ChatServerHandler();

            var manager = new CommandProxyManager();
            manager.session = session;
            manager.init();

            Console.ReadLine();
        }
    }
}
