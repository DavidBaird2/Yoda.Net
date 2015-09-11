using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking;
using Yoda.Net.Proxy.DefaultHandler;

namespace Yoda.Net.Proxy
{
    public class ProxySession
    {
        public CommandProxy proxy { get; set; }
        public ICommandBridge ChatProxy;

        public IMessageHandler InfoServerHandler { get; set; }
        public IMessageHandler InfoClientHandler { get; set; }
        public IMessageHandler ChatServerHandler { get; set; }
        public IMessageHandler ChatClientHandler { get; set; }

        public string ticket { get; set; }
        public string amebaAuthTicket { get; set; }
        public string username;
        public ICommandBridge InfoProxy;

        public ProxySession(CommandProxy proxy)
        {
            //Set Default Message Handler 
            InfoClientHandler = new InfoClientHandler(proxy, this);
            InfoServerHandler = new InfoServerHandler(proxy, this);
            ChatClientHandler = new ChatClientHandler(proxy, this);
            ChatServerHandler = new ChatServerHandler(proxy, this);
            this.proxy = proxy;
        }

        public void ApplyInfoHandler()
        {
            InfoProxy.SetServerHandler(InfoServerHandler);
            InfoProxy.SetClientHandler(InfoClientHandler);
        }
    }


}
