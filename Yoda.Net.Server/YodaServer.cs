using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Server.Chat;
using Yoda.Net.Server.DataAccess;
using Yoda.Net.Server.Info;

namespace Yoda.Net.Server
{
    class YodaServer
    {
        private static InfoServer infoServer;
        private static ChatServer chatServer;
        static void Main(string[] args)
        {
            var policyServer = new Yoda.Net.Networking.PolicyServer();
            policyServer.init();

         //   Database.SetInitializer(new DropCreateDatabaseAlways<AmebaContext>());
            infoServer = new Yoda.Net.Server.Info.InfoServer();
            infoServer.Start(new IPEndPoint(IPAddress.Any, 1935));

            chatServer = new Yoda.Net.Server.Chat.ChatServer();
            chatServer.Start(new IPEndPoint(IPAddress.Any, 1936));
            Console.ReadLine();


        }
        public static InfoServer GetInfo()
        {
            return infoServer;
        }
        public static ChatServer GetChat()
        {
            return chatServer;
        }
    }
}
