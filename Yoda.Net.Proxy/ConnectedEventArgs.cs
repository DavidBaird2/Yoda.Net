using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Proxy
{
    public class ConnectedEventArgs : EventArgs
    {
        private ProxySession session;
        private bool forceDissconect = false;

        public ProxySession Session
        {
            get { return session; }
            set { session = value; }
        }

        public bool ForceDissconect
        {
            get { return forceDissconect; }
            set { forceDissconect = value; }
        }

        public ConnectedEventArgs(ProxySession session)
        {
            // TODO: Complete member initialization
            this.session = session;
        }
      
    }
}
