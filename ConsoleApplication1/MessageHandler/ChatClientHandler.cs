using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Packet.Chat;
using Yoda.Net.Networking.Packet.Info.Shop;
using Yoda.Net.Networking.Packet.Info.User;
using Yoda.Net.Proxy;
namespace ConsoleApplication1
{
    class ChatClientHandler : IMessageHandler
    {
        private ProxySession session;


        public ChatClientHandler(ProxySession session)
        {
            this.session = session;
        }
        public CommandRouteOption onTalk(TalkData talk)
        {
            session.ChatProxy.SendMessageToServer(new DoCrackActionData("hello"));
            return CommandRouteOption.Nothing;
        }
        

    }
}
