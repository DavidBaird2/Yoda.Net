using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Event
{
  public  class EventUserRankingData
    {
        public int like;
        public string userCode { get; set; }

        public string nickName { get; set; }

        public int rank { get; set; }

        public bool _event { get; set; }

        public string eventTitle { get; set; }
    }
}
