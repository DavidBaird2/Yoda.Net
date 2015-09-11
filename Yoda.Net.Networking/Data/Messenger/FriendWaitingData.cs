using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Messenger
{
    public class FriendWaitingData
    {
        public string amebaId { get; set; }

        public string message { get; set; }

        public sbyte status { get; set; }

        public string hexCode { get; set; }

        public string nickname { get; set; }

        public string requestAt { get; set; }
    }
}
