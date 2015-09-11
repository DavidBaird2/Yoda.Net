using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Client.Web
{
   public class CustomWebClient : WebClient
    {
        public CookieContainer cookieContainer = new CookieContainer();
     
        protected override WebRequest GetWebRequest(Uri address)
        {
            var request = base.GetWebRequest(address);
            if (request is HttpWebRequest)
            {
                (request as HttpWebRequest).CookieContainer = cookieContainer;
            }
            return request;
        }

      

    }
}
