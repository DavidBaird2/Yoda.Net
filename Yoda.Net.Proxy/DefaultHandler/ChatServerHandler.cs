using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking;

using Yoda.Net.Networking.Data.Common;
using Yoda.Net.Networking.Packet.Chat;
using Yoda.Net.Proxy;

namespace Yoda.Net.Proxy.DefaultHandler
{
    class ChatServerHandler : IMessageHandler
    {
       
        private CommandProxy commandProxyManager;
        private ProxySession targetSession;
     

        public ChatServerHandler(CommandProxy commandProxyManager, ProxySession targetSession)
        {
            // TODO: Complete member initialization
            this.commandProxyManager = commandProxyManager;
            this.targetSession = targetSession;
        }
 


       
    }
}
