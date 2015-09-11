using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Announce
{
    public class AnnounceData
    {
        public double announceId { get; set; }

        public string title { get; set; }

        public string link { get; set; }

        public int orderNum { get; set; }

        public bool checkedValue { get; set; }

        public int displayType { get; set; }

        public int iconId { get; set; }

        public string jumpAreaCode { get; set; }

        public string jumpAreaCategory { get; set; }

        public string jumpGameLink { get; set; }

        public DateTime startTime { get; set; }

        public DateTime createTime { get; set; }
    }
}
