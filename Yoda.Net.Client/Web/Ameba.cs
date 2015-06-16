using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Client.Web
{
    public class Ameba
    {
        public static void Login(BotSession client)
        {
            var hap = new HtmlAgilityPack.HtmlWeb();
            var doc = hap.Load("http://pigg.ameba.jp", "GET");

            var loginUrl = doc.DocumentNode.SelectNodes("//*[@id=\"playBox\"]/p/a")[0].Attributes["href"].Value;
                
                /*.Select(a => new
                      {
                        Url = a.Attributes["href"].Value.Trim(),
                      });*/

        //    var loginUrl = node.Single().Url;

            doc = hap.Load(loginUrl);

           
        }
    }
}
