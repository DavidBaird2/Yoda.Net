namespace Yoda.Net.Networking.Packet.Info.Event
{


    using System;
    using System.Collections;

    public class CheckEventRankingResultData : ICommandData
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
            enable = In.readBoolean();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeBoolean(enable);
            return;
        }


        public bool enable { get; set; }
    }
}

