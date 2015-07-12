using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking;
using Yoda.Net.Proxy;

namespace ConsoleApplication1
{
    class InfoClientHandler : IMessageHandler
    {
        private ProxySession session;
        public InfoClientHandler(ProxySession session)
        {
            this.session = session;
        }
    }
}
