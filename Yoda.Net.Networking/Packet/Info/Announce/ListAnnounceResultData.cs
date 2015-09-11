using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking.Data.Announce;



namespace Yoda.Net.Networking.Packet.Info.Announce
{
    public class ListAnnounceResultData : ICommandData
    {


        public int packetId
        {
            get
            {
                return PacketId.LIST_ANNOUNCE_RESULT;
            }
        }

        public void readData(PiggStream In)
        {

            var count = In.readInt();
			this.list = new List<AnnounceData>();



            count.Times(() =>
            {
                var data = new AnnounceData();
                data.announceId = In.readDouble();
                DateTime time = DateTime.Parse("1970/1/1 09:00");
                time.AddMilliseconds(data.announceId);
                data.createTime = time;
                data.title = In.readUTF();
                data.link = In.readUTF();

                if (In.readBoolean()) data.startTime = In.readTime();

                data.orderNum = In.readInt();
                data.checkedValue = In.readBoolean();
                data.displayType = In.readInt();
                data.iconId = In.readInt();
                data.jumpAreaCode = In.readUTF();
                data.jumpAreaCategory = In.readUTF();
                data.jumpGameLink = In.readUTF();
                this.list.Add(data);
             
            });

			this.piggNewsData = new PiggNewsData();
			this.piggNewsData.readData(In);

        }

        public void writeData(PiggStream Out)
        {


            return;
        }




        public List<AnnounceData> list { get; set; }

        public PiggNewsData piggNewsData { get; set; }
    }
}
