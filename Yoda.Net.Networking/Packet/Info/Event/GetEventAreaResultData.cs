namespace Yoda.Net.Networking.Packet.Info.Event
{


    using Yoda.Net.Networking.Packet.Data.Event;
    using System;
    using System.Collections;
    using Yoda.Net.Networking.Data.Event;

    public class GetEventAreaResultData : ICommandData
    {
        public EventData eventData;
        public int myEventCondition;
        public string myEventTitle;
        public bool isSeen;

        public int packetId
        {
            get
            {
                return PacketId.GET_NOTICE_BOARD_MESSAGE_OF_AREA_RESULT;
            }
        }
        public GetEventAreaResultData()
        {

        }
        public void readData(PiggStream In)
        {
            this.eventData = new EventData();
            this.myEventCondition = In.readInt();
            this.isSeen = In.readBoolean();
            this.myEventTitle = In.readUTF();
            this.eventData.roomEventCondition = In.readBoolean();
            if (this.eventData.roomEventCondition)
            {

                this.eventData.areaCategory = In.readUTF();
				this.eventData.areaCode = In.readUTF();
				this.eventData.areaTitle = In.readUTF();
				this.eventData.category = In.readUTF();
				this.eventData.title = In.readUTF();
				this.eventData.description = In.readUTF();
				this.eventData.createTime = In.readTime();
				this.eventData.image = In.readBoolean();
				this.eventData.originPath = In.readUTF();
				this.eventData.thumbPath = In.readUTF();
				this.eventData.numPeople = In.readInt();
				this.eventData.ownerUserCode = In.readUTF();
				this.eventData.ownerName = In.readUTF();
				this.eventData.dataType = In.readUTF();
				this.eventData.publishing = In.readByte();
				this.eventData.likeEnabled = In.readBoolean();
				this.eventData.roomIndex = In.readInt();
            }

        }

        public void writeData(PiggStream Out)
        {

            throw new NotImplementedException();
        }
    }
}

