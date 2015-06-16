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
        public CommandProxy InfoProxy;
        public List<CommandProxy> ChatProxy = new List<CommandProxy>();
        public IMessageDelegate InfoClientHandler;
        public IMessageDelegate InfoServerHandler;
        public IMessageDelegate ChatClientHandler;
        public IMessageDelegate ChatServerHandler;
        public string LastGetAreaServer = "";
    }
}
