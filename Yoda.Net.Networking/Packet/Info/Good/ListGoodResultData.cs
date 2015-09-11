namespace Yoda.Net.Networking.Packet.Info.Good
{


    using Yoda.Net.Networking.Packet.Info;
    using System.Collections;

    using System;
    using Yoda.Net.Networking.Data.Good;
    using System.Collections.Generic;

    public class ListGoodResultData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.LIST_GOOD_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            goodList = new List<GoodData>();
            GoodData goodData = null;
            var count = In.readInt();

            this.type = In.readUTF();


            count.Times
                (() =>
                {
                    goodData = new GoodData();
                    goodData.userCode = In.readUTF();
                    goodData.nickname = In.readUTF();
                    goodData.amebaId = In.readUTF();
                    goodData.date = In.readTime();
                    goodData.fromID = In.readUTF();
                    goodData.sent = In.readBoolean();
                    goodData.oneMessage = In.readUTF();
                    goodData.friendable = In.readBoolean();
                    this.goodList.Add(goodData);

                });

            this.total = In.readInt();
        }

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
        
        }

        public string type { get; set; }

        public List<GoodData> goodList { get; set; }

        public int total { get; set; }
    }
}

