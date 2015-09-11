namespace Yoda.Net.Networking.Packet.Info.Event
{


    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Yoda.Net.Networking.Data.Event;

    public class ListEventRankingResultData : ICommandData
    {
        public ListEventRankingResultData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.LIST_NOTICE_BOARD_RANKING_RESULT;
            }
        }


        public void readData(PiggStream In)
        {
            EventUserRankingData rankingData = null;

            this.myData = new MyRankingData();
            this.myData.rankin = In.readBoolean();
            this.myData.userCode = In.readUTF();
            this.myData.nickName = In.readUTF();
            this.myData.rank = In.readInt();
            this.myData.like = In.readInt();

            int count = In.readInt();

            this.list = new List<EventUserRankingData>();

            int i = 0;

            while (i < count)
            {
                rankingData = new EventUserRankingData();
                rankingData.userCode = In.readUTF();
                rankingData.nickName = In.readUTF();
                rankingData.rank = In.readInt();
                rankingData.like = In.readInt();
                rankingData._event = In.readBoolean();
                rankingData.eventTitle = In.readUTF();
                this.list.Add(rankingData);
                i++;



            }
        }

        internal MyRankingData myData { get; set; }
        public List<EventUserRankingData> list { get; set; }
        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();

        }


    }
}

