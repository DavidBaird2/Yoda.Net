using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Packet.Info.Area;
using Yoda.Net.Proxy;

namespace ConsoleApplication1
{
    class InfoServerHandler : IMessageDelegate
    {
        private ProxySession session;
        public InfoServerHandler(ProxySession session)
        {
            this.session = session;
        }
        public CommandRouteOption onGetAreaResultData(GetAreaResultData data )
        {
            session.LastGetAreaServer = data.server.Split(':')[0];
            return CommandRouteOption.Nothing;
        }
    }
}
