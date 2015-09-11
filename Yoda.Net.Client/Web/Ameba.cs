using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Client.Web
{
    public class Ameba
    {

        //Thanks Credit for Hirotamu!
        //He is nice guy

        public static void Login(BotUser client)
        {
            /*var hap = new HtmlAgilityPack.HtmlWeb();
            var doc = hap.Load("http://pigg.ameba.jp", "GET");

            var loginUrl = doc.DocumentNode.SelectNodes("//*[@id=\"playBox\"]/p/a")[0].Attributes["href"].Value;
                

            doc = hap.Load(loginUrl);
            */
            NameValueCollection vals = new NameValueCollection();
            vals["username"] = client.amebaId;
            vals["password"] = client.password;
            string url = "https://login.user.ameba.jp/web/login";

            string result = HttpPost(url, client, vals);

            var cookie = client.cookie.List();

            var N = cookie.Where(i => i.Name == "N").FirstOrDefault();

            if (N == null)
                throw new Exception("ログインに失敗しました");

            client.authTicket = N.Value;

            doSSO(client);
        }

        private static void doSSO(BotUser client)
        {

            var result = HttpGet("http://pigg.ameba.jp", client);

            var cookie = client.cookie.List();

            var Pigg = cookie.Where(i => i.Name == "pigg").FirstOrDefault();

            if (Pigg == null)
                throw new Exception("ログインに失敗しました");

            client.ticket = Pigg.Value;

            

        }
        public static string HttpPost(string url,BotUser user ,NameValueCollection vals)
        {
            CustomWebClient wc = new CustomWebClient();
            wc.cookieContainer = user.cookie;

            wc.Headers.Add("User-Agent",
                 user.userAgent);
            string result = Encoding.UTF8.GetString(wc.UploadValues(url, vals));

            return result;
        }
        
        
        public static string HttpGet(string url ,BotUser user)
        {
            CustomWebClient wc = new CustomWebClient();
            wc.cookieContainer = user.cookie;

            wc.Headers.Add("User-Agent",
                 user.userAgent);
            string result = wc.DownloadString(url);

            return result;
        }
      
    }
}
