using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Announce
{
    public class AnnounceEventData
    {
        public string eventCode { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public string link { get; set; }

        public int eventType { get; set; }

        public int iconType { get; set; }

        public int backgroundType { get; set; }

        public bool isSeen { get; set; }

        internal void readData(PiggStream hug1)
        {
          			this.announceEventId = hug1.readDouble();
			this.title = hug1.readUTF();
			this.description = hug1.readUTF();
			this.link = hug1.readUTF();
			this.startTime = hug1.readTime();


            this.endTime = hug1.readDouble();
			this.orderNum = hug1.readInt();
			this.isSeen = hug1.readBoolean();
			this.eventType = hug1.readInt();
			this.iconType = hug1.readInt();
			this.backgroundType = hug1.readInt();
			this.eventCode = hug1.readUTF();
			this.categoryCode = hug1.readUTF();
			this.subCategoryCode = hug1.readUTF();
			this.outsideOnly = hug1.readBoolean();
			this.swfPath = hug1.readUTF();

            this.eventStartTime = hug1.readDouble();

            this.eventEndTime = hug1.readDouble();
			this.isZoneUnder16 = hug1.readBoolean();
			this.isZoneOver16ToUnder18 = hug1.readBoolean();
			this.isZoneOver18ToUnder20 = hug1.readBoolean();
			this.isZoneOver20 = hug1.readBoolean();
			this.isExternalLink = hug1.readBoolean();
			this.innerStartTime = hug1.readDouble();
			this.innerEndTime = hug1.readDouble();
        }

        public double announceEventId { get; set; }

        public DateTime startTime { get; set; }

        public int orderNum { get; set; }

        public string categoryCode { get; set; }

        public string subCategoryCode { get; set; }

        public string swfPath { get; set; }

        public bool outsideOnly { get; set; }

        public double innerEndTime { get; set; }

        public double innerStartTime { get; set; }

        public bool isExternalLink { get; set; }

        public bool isZoneOver20 { get; set; }

        public bool isZoneOver18ToUnder20 { get; set; }

        public bool isZoneOver16ToUnder18 { get; set; }

        public bool isZoneUnder16 { get; set; }

        public double endTime { get; set; }

        public double eventStartTime { get; set; }

        public double eventEndTime { get; set; }
    }
}
