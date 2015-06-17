using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Packet.Chat;
using Yoda.Net.Proxy;

namespace ConsoleApplication1
{
    class ChatServerHandler : IMessageDelegate
    {
        public ChatServerHandler(ProxySession session)
        {

        }
        public CommandRouteOption onGetAreaResult(EnterUserRoomResultData data)
        {
            data.areaData.areaName = "test";
            return CommandRouteOption.Nothing;
        }
    }
}
