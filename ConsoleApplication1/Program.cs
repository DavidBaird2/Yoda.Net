
using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Yoda.Net.Networking;
using Yoda.Net.Proxy;


namespace ConsoleApplication1
{

    class Program
    {

        static void Main(string[] args)
        {
            //クロスドメイン問題解消用のFlashポリシーサーバー　
            var policySever = new PolicyServer();
            policySever.init();
            var manager = new CommandProxy();
            manager.init();
            manager.onLoginClient += (sender, e) =>
            {
                var session = e.Session;
                
                //既に誰かがログインしてる場合
           /*     if (manager.sessionList.Count() != 1)
                {;
                    //強制的に切断
                    e.ForceDissconect = true;
                    return;
                }


             */ session.InfoServerHandler = new InfoServerHandler(session);
                session.InfoClientHandler = new InfoClientHandler(session);
                session.ChatServerHandler = new ChatServerHandler(session);
                session.ChatClientHandler = new ChatClientHandler(session);
                session.ApplyInfoHandler();
            };


          


            Console.ReadLine();



        }

      


    }
}
