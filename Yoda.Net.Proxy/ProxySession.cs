using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking;

namespace Yoda.Net.Proxy
{
    public class ProxySession
    {
        public string username;
        public CommandProxyTest InfoProxy;
        public List<CommandProxyTest> ChatProxy = new List<CommandProxyTest>();
        public IMessageHandler InfoClientHandler;
        public IMessageHandler InfoServerHandler;
        public IMessageHandler ChatClientHandler;
        public IMessageHandler ChatServerHandler;
        public string LastGetAreaServer = "";
        private System.Diagnostics.Stopwatch time = new System.Diagnostics.Stopwatch();
    }
}
