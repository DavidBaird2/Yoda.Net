using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Packet.Chat;
using Yoda.Net.Proxy;

namespace ConsoleApplication1
{
    class ChatClientHandler : IMessageDelegate
    {
        public ChatClientHandler()
        { 
        }
        public CommandRouteOption onTalkData(TalkData data)
        {
            return CommandRouteOption.Nothing;
        }
    }
}
