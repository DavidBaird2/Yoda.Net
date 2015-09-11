namespace Yoda.Net.Networking.Packet.Info.Event
{


    using System;
    using System.Collections;
    using Yoda.Net.Networking.Data.Event;

    public class GetEventRankingData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.GET_NOTICE_BOARD_RANKING;
            }
        }

        public void readData(PiggStream In)
        {
            type = In.readByte();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeByte(this.type);
          
        }


        public sbyte type { get; set; }
    }
}

