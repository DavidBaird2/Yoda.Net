namespace Yoda.Net.Networking.Packet.Info.Event
{


    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Yoda.Net.Networking.Data.Event;

    public class ListEventSummaryResultData : ICommandData
    {
        public ListEventSummaryResultData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.LIST_NOTICE_BOARD_MESSAGE_SUMMARY_RESULT;
            }
        }


        public void readData(PiggStream In)
        {
            EventData eventData = null;
			int count = In.readInt();

			this.list = new List<EventData>();

			var i = 0;

			while(i < count){
				eventData = new EventData();
				eventData.areaCategory = In.readUTF();
				eventData.areaCode = In.readUTF();
				eventData.areaTitle = In.readUTF();
				eventData.category = In.readUTF();
				eventData.title = In.readUTF();
				eventData.description = In.readUTF();
				eventData.createTime = In.readTime();
				eventData.numPeople = In.readInt();
				eventData.ownerUserCode = In.readUTF();
				eventData.ownerName = In.readUTF();
				eventData.publishing = In.readByte();
				this.list.Add( eventData);
				i++;
			}
        }

      
        public void writeData(PiggStream Out)
        {

            throw new NotImplementedException();
        }



        public List<EventData> list { get; set; }
    }
}

