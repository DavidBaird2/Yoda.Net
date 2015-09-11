using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Packet.Info.User;
using Yoda.Net.Proxy;

namespace Yoda.Net.Proxy.DefaultHandler
{
    class InfoClientHandler : IMessageHandler
    {
 
        private CommandProxy commandProxyManager;
        private ProxySession targetSession;
  

        public InfoClientHandler(CommandProxy commandProxyManager, ProxySession targetSession)
        {
            // TODO: Complete member initialization
            this.commandProxyManager = commandProxyManager;
            this.targetSession = targetSession;
        }

        
        public CommandRouteOption onLogin(LoginData data)
        {
            targetSession.amebaAuthTicket = data.amebaAuthTicket;
            targetSession.ticket = data.ticket;
            commandProxyManager.handleLogin(targetSession);
            return CommandRouteOption.Nothing;
        }
    }
}
