namespace Yoda.Net.Networking.Packet.Info.Event
{


    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Yoda.Net.Networking.Data.Event;

    public class ListEventSummaryData : ICommandData
    {
        public ListEventSummaryData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.LIST_NOTICE_BOARD_MESSAGE_SUMMARY;
            }
        }


        public void readData(PiggStream In)
        {

        }

      
        public void writeData(PiggStream Out)
        {

         
        }



    }
}

