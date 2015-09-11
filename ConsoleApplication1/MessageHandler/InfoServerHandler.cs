using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Common;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Data.Action;
using Yoda.Net.Networking.Packet.Info;
using Yoda.Net.Networking.Packet.Info.Action;
using Yoda.Net.Networking.Packet.Info.Area;
using Yoda.Net.Networking.Packet.Info.Friend;
using Yoda.Net.Networking.Packet.Info.MyGame;
using Yoda.Net.Networking.Packet.Info.User;
using Yoda.Net.Proxy;

namespace ConsoleApplication1
{
    class InfoServerHandler : IMessageHandler
    {
        private ProxySession session;
        public static string myUserCode = "";



        public InfoServerHandler(ProxySession session)
        {
            this.session = session;
        }

        public CommandRouteOption onGetAreaResultData(GetAreaResultData data)
        {
            session.proxy.moveManager.AddAreaMovement(session, data.category, data.code, data.server);
           
            
            return CommandRouteOption.Nothing;
        }

    }
}
