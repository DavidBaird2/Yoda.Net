namespace Yoda.Net.Networking.Packet.Info.Event
{


    using System;
    using System.Collections;
    using Yoda.Net.Networking.Data.Event;

    public class GetEventRankingResultData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.GET_NOTICE_BOARD_RANKING_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            this.myData = new MyRankingData();
            this.myData.rankin = In.readBoolean();
            this.myData.userCode = In.readUTF();
            this.myData.nickName = In.readUTF();
            this.myData.rank = In.readInt();
            this.myData.like = In.readInt();
        }

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
          
        }

        internal MyRankingData myData { get; set; }
    }
}

