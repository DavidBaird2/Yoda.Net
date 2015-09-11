using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Client
{
    public class BotUser
    {
        public string username;
        public string password;
        public string hexCode;
        public string userAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729; rv:11.0) like Gecko";
        public string ticket;
        public string authTicket;
        public string frmId ="";
        public string flashPlayerVersion = "18.0";

        public CookieContainer cookie = new CookieContainer();
        public byte[] secureCode { get; set; }

        public string amebaId { get; set; }
    }
}
