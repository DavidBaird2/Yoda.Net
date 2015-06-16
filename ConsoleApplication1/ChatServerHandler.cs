using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking;
using Yoda.Net.Proxy;

namespace ConsoleApplication1
{
    class ChatServerHandler : IMessageDelegate
    {
        public ChatServerHandler()
        {

        }
        public CommandRouteOption onGetAreaResult(Yoda.Net.Networking.Packet.Chat.EnterUserRoomResultData data)
        {
            return CommandRouteOption.Nothing;
        }
    }
}
