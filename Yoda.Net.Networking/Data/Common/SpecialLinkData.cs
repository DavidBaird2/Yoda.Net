using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Common
{
    public class SpecialLinkData
    {
        public static string ICON_NEW = "new";
        public static string TYPE_LINK = "url";
        public static string TYPE_ASK = "ask";
        public static string TYPE_SHOP = "shop";
        public static string TYPE_AREA = "area";
        public static string TYPE_TIMETRAVEL = "timetravel";
        public static string TYPE_CLUB = "club";
        public static string TYPE_SCRATCH = "scratch";


        public double linkId { get; set; }

        public string title { get; set; }

        public string link { get; set; }

        public string type { get; set; }

        public string iconType { get; set; }

        public int orderNum { get; set; }

        public bool checkedValue { get; set; }

        public DateTime startTime { get; set; }
    }
}
