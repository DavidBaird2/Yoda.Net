using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking.Data.Announce;



namespace Yoda.Net.Networking.Packet.Info.Announce
{
    public class ListAnnounceQuestResultData : ICommandData
    {


        public int packetId
        {
            get
            {
                return PacketId.LIST_ANNOUNCE_QUEST_RESULT;
            }
        }

        public void readData(PiggStream In)
        {


            var count = In.readInt();
            this.list = new List<AnnounceQuestData>();
            count.Times(() =>
            {
               var data = new AnnounceQuestData();
                data.gameCode = In.readUTF();
                data.status = In.readByte();
                data.incentiveItemCode = In.readUTF();
                data.incentiveItemType = In.readUTF();
                data.incentiveItemName = In.readUTF();
                this.list.Add(data);
            });
            return;

        }

        public void writeData(PiggStream Out)
        {


            return;
        }



        public List<AnnounceQuestData> list { get; set; }
    }
}
