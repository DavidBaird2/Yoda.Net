using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking.Data.Announce;



namespace Yoda.Net.Networking.Packet.Info.Announce
{
    public class ListAnnounceFirstDayResultData : ICommandData
    {
     
        public string code;
  
        public int packetId
        {
            get
            {
                return PacketId.LIST_ANNOUNCE_FIRST_DAY_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
         
         
          
			this.hasList = In.readBoolean();

			if(this.hasList){
                var count = In.readInt();
				this.list = new List<AnnounceEventData>();
				
                count.Times(() =>
                {
                    var data = new AnnounceEventData();
                    data.eventCode = In.readUTF();
                    data.title = In.readUTF();
                    data.description = In.readUTF();
                    data.link = In.readUTF();
                    data.eventType = In.readInt();
                    data.iconType = In.readInt();
                    data.backgroundType = In.readInt();
                    data.isSeen = false;
                    this.list.Add(data);
            
                });
			}
            return;

        }

        public void writeData(PiggStream Out)
        {
           
       
            return;
        }

        public bool hasList { get; set; }

        public List<AnnounceEventData> list { get; set; }
    }
}
