using System;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Packet.Chat;
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



    }
}
