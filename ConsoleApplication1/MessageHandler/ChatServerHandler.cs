using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Packet.Chat;
using Yoda.Net.Proxy;

namespace ConsoleApplication1
{
    class ChatServerHandler : IMessageHandler
    {
        private ProxySession session;
        public ChatServerHandler(ProxySession session)
        {
            this.session = session;
        }
        public CommandRoute onEnterUserRoomResult(EnterUserRoomResultData data)
        {
            return CommandRoute.Nothing;
        }
    }
}
