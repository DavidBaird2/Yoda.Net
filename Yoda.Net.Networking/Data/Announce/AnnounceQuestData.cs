using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Announce
{
    public class AnnounceQuestData
    {
        public string gameCode { get; set; }

        public sbyte status { get; set; }

        public string incentiveItemCode { get; set; }

        public string incentiveItemType { get; set; }

        public string incentiveItemName { get; set; }
    }
}
