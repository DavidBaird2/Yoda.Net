using DNS.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Common
{
    public class DNS
    {

        private static string DNS_SERVER_ADDR = "8.8.8.8";
        public static  string ResolveDNS(string host)
        {
            var records = (new DnsClient(DNS_SERVER_ADDR)).Lookup(host).FirstOrDefault();
            return records.ToString();
        }
    }
}
