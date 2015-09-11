using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoda.Net.Networking
{
    public class ProxySession
    {
        public string username;
        public CommandProxy InfoProxy;
        public List<CommandProxy> ChatProxy = new List<CommandProxy>();
        public IMessageDelegate InfoClientMessageDelegate;
        public IMessageDelegate InfoServerMessageDelegate;
        public IMessageDelegate ChatClientMessageDelegate;
        public IMessageDelegate ChatServerMessageDelegate;
        public string LastGetAreaServer = "";
    }
}
