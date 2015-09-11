namespace Yoda.Net.Networking.Packet.Info.Calendar
{


    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Yoda.Net.Networking.Data.Calendar;
    public class ListCalendarData  : ICommandData
    {
       
        public ListCalendarData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.LIST_CALENDAR;
            }
        }

        public void readData(PiggStream In)
        {
       
		
            return;
        }

        public void writeData(PiggStream Out)
        {
         
            return;
        }

      
    }
}

