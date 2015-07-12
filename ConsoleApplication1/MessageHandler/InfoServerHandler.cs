using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Data.Action;
using Yoda.Net.Networking.Packet.Info.action;
using Yoda.Net.Networking.Packet.Info.Area;
using Yoda.Net.Networking.Packet.Info.friend;
using Yoda.Net.Proxy;

namespace ConsoleApplication1
{
    class InfoServerHandler : IMessageHandler
    {
        private ProxySession session;
        public InfoServerHandler(ProxySession session)
        {
            this.session = session;
        }

        public CommandRoute onGetAreaResultData(GetAreaResultData data )
        {
            session.LastGetAreaServer = data.server.Split(':')[0];
            return CommandRoute.Nothing;
        }
        public CommandRoute onListActionResult(ListActionResultData data)
        {
            //data.list.Add(new ActionData());
            return CommandRoute.Edit;
        }
  
    }
}
