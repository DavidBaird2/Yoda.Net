namespace Yoda.Net.Networking.Packet.Info.News
{
    
    
    using Yoda.Net.Networking.Packet.Info;
    using System.Collections;
    using System;
    using Yoda.Net.Networking.Data.Common;
    using System.Collections.Generic;

    public class GetAmebaBarLinksData : ICommandData
    {
   
 

        public int packetId
        {
            get
            {
                return PacketId.LIST_LINK_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
     
            var count = In.readInt();
			this.list = new List<SpecialLinkData>();

            count.Times(() =>
            {
               var data = new SpecialLinkData();
                data.linkId = In.readDouble();
                data.title = In.readUTF();
                data.link = In.readUTF();
                data.type = In.readUTF();
                data.iconType = In.readUTF();

                if (In.readBoolean()) data.startTime = In.readTime();

                data.orderNum = In.readInt();
                data.checkedValue = In.readBoolean();
                this.list.Add(data);
             
            });

        }

        public void writeData(PiggStream Out)
        {
   

            return;
        }

        public List<SpecialLinkData> list { get; set; }
    }
}

