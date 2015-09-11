using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Client.Delegate;
using Yoda.Net.Client.MessageHandler;
using Yoda.Net.Common;
using Yoda.Net.Networking.Packet.Info.Area;
using Yoda.Net.Queue;

namespace Yoda.Net.Client
{
    public class AmebaPigg
    {
        public QueueManager queue;

        public InfoClient InfoClient;
        public List<ChatClient> ChatClientList;

        public BotUser session;
     
        public AmebaPigg(BotUser session)
        {
            ChatClientList = new List<ChatClient>();
            this.session = session;
        }

        public void Start()
        {
            InfoClient = new InfoClient(session);
            InfoClient.SetMessageHandler(new InfoServerHandler(this));

            var ip = DNS.ResolveDNS("info.pigg.ameba.jp");

            InfoClient.Connect(ip, 1935);
        }

   
        public void MoveArea(string category, string code)
        {

            if (ChatClientList.Where(i => i.AreaCategory == category && i.AreaCode == code).SingleOrDefault() != null)
            {
                return; //同じ部屋には移動できない
            }

            InfoClient.GetArea(category, code);

        }

        public void OpenChat(string server, int port, string category, string code)
        {
 
            ChatClient client = new ChatClient(this);
            client.SetMessageHandler(new ChatServerHandler(this, client));
            client.AreaCategory = category;
            client.AreaCode = code;
            ChatClientList.Add(client);
            var ip = DNS.ResolveDNS(server);
            client.Connect(ip, port);
        }
    }
}
