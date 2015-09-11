using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoda.Net.Proxy.Area
{
    public class EnterAreaQueue
    {
        public ProxySession session;
        public string category;
        public string code;
        public string server;

        public EnterAreaQueue(ProxySession session, string category, string code, string server)
        {
            // TODO: Complete member initialization
            this.session = session;
            this.category = category;
            this.code = code;
            this.server = server;
        }
        public string GetHostResolved()
        {
            return Common.DNS.ResolveDNS("");
        }
  
    }
}
