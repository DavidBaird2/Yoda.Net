using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Data.Action;
using Yoda.Net.Networking.Packet.Info;
using Yoda.Net.Networking.Packet.Info.Action;
using Yoda.Net.Networking.Packet.Info.Area;
using Yoda.Net.Networking.Packet.Info.Friend;
using Yoda.Net.Networking.Packet.Info.User;
using Yoda.Net.Proxy;

namespace Yoda.Net.Proxy.DefaultHandler
{
    class InfoServerHandler : IMessageHandler
    {
        private CommandProxy commandProxyManager;
        private ProxySession targetSession;

        public InfoServerHandler(CommandProxy commandProxyManager, ProxySession targetSession)
        {
            // TODO: Complete member initialization
            this.commandProxyManager = commandProxyManager;
            this.targetSession = targetSession;
        }
        public CommandRouteOption onGetAreaResultData(GetAreaResultData data)
        {


        //    targetSession.LastGetAreaServer = data.server.Split(':')[0];

            return CommandRouteOption.Nothing;
        }
       

  
    }
}
