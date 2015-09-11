namespace Yoda.Net.Networking.Packet.Info.Calendar
{


    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Yoda.Net.Networking.Data.Calendar;
    public class ListCalendarResultData : ICommandData
    {
        public int buypoint;
        public ListCalendarResultData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.LIST_CALENDAR_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
       
			this.calendarData = new Hashtable();
			this.calendarData["systemDate"] = In.readTime();
			this.list = new List<CalendarData>();
            int count = In.readInt();
			var i = 0;

            while (i < count)
            {
				var data = new CalendarData();
				data.eventDate = In.readTime();
				data.iconID = In.readInt();
				data.title = In.readUTF();
				data.text1 = In.readUTF();
				data.text2 = In.readUTF();
				data.linkUrl = In.readUTF();
				this.list.Add(data);
				i++;
			}

			this.calendarData["topics"] = In.readUTF();
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(buypoint);
            return;
        }

        public Hashtable calendarData { get; set; }

        public List<CalendarData> list { get; set; }
    }
}

