namespace Yoda.Net.Networking.Packet.Info.Event
{


    using System;
    using System.Collections;

    public class CheckEventRankingData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.CHECK_NOTICE_BOARD_RANKING_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
   
        }

        public void writeData(PiggStream Out)
        {
            
            return;
        }


    }
}

