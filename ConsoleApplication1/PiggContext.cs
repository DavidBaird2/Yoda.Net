using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Proxy;

namespace ConsoleApplication1
{
    class PiggContext
    {
        private ProxySession session;

    
        public PiggContext(ProxySession session)
        {
            this.session = session;
        }

        public ProxySession Session
        {
            get { return session; }
            set { session = value; }
        }
      
    }
}
