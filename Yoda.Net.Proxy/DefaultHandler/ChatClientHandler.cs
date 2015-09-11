using System;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Packet.Chat;
using Yoda.Net.Proxy;

namespace Yoda.Net.Proxy.DefaultHandler
{
    class ChatClientHandler : IMessageHandler
    {

        private CommandProxy commandProxyManager;
        private ProxySession targetSession;


        public ChatClientHandler(CommandProxy commandProxyManager, ProxySession targetSession)
        {
            this.commandProxyManager = commandProxyManager;
            this.targetSession = targetSession;
        }



    }
}
