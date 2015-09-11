using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Yoda.Net.Client;
using Yoda.Net.Client.Web;
using Yoda.Net.Networking.Packet.Chat;
using System.Net.WebSockets;
namespace BotExample
{
    class Program
    {
        static List<AmebaPigg> clients = new List<AmebaPigg>();
        static async void Connect()
        {
          
          //  var ws = new ClientWebSocket();
         //   await ws.ConnectAsync(new Uri("wss://chat02.pigg.ameba.jp:443/command"), CancellationToken.None);
          //  ws.Options.ClientCertificates
        }
        static void Main(string[] args)
        {
            Connect();
        

            AddUser("koundara", "pw");

            Thread.Sleep(1000);


            int i = 0;

            foreach (AmebaPigg pigg in clients)
            {
                  i++;
                  string code = "hokaido_farm_140702_" + i.ToString().PadLeft(3, '0');
                  pigg.MoveArea("hokkaido", code);
              
            }

            Thread.Sleep(1000);

            while (true)
            {
                foreach (AmebaPigg pigg in clients)
                {
                    pigg.ChatClientList[0].SendCommand(new TalkData() { message = "test" });

                    Thread.Sleep(1000);
                }
            }


            Console.ReadLine();


        }

       /* static void MoveAreaAll(string category,string code)
        {
            foreach(AmebaPigg pigg in clients)
            {
                pigg.MoveArea(category,code);
            }
        }*/

        static void AddUser(string username ,string password)
        {
            var session = new BotUser();

            session.amebaId = username;

            session.password = password;

            Ameba.Login(session);

            AmebaPigg pigg = new AmebaPigg(session);

            pigg.Start();

            clients.Add(pigg);
        }


    }
}
