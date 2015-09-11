using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Calendar
{
    public class CalendarData
    {
        public DateTime eventDate { get; set; }

        public int iconID { get; set; }

        public string title { get; set; }

        public string text1 { get; set; }

        public string text2 { get; set; }

        public string linkUrl { get; set; }
    }
}
