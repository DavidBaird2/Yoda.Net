namespace Yoda.Net.Networking.Packet.Info.Event
{
    

using Yoda.Net.Networking.Packet.Data.Event;
using System;
using System.Collections;
    using Yoda.Net.Networking.Packet.Data.Event;
    using Yoda.Net.Networking.Data.Event;

    public class GetEventAreaResultData : IPacket
    {
        public  EventData @event;
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
        public void readData(AmebaStream param1)
        {
                      this.@event = new EventData();
            this.myEventCondition = param1.readInt();
            this.isSeen = param1.readBoolean();
            this.myEventTitle = param1.readUTF();
            this.@event.roomEventCondition = param1.readBoolean();
            if (this.@event.roomEventCondition)
            {
                this.@event.areaCategory = param1.readUTF();
                this.@event.areaCode = param1.readUTF();
                this.@event.areaTitle = param1.readUTF();
                this.@event.category = param1.readUTF();
                this.@event.title = param1.readUTF();
                this.@event.description = param1.readUTF();
                this.@event.createTime = param1.readDouble();
                this.@event.image = param1.readBoolean();
                this.@event.originPath = param1.readUTF();
                this.@event.thumbPath = param1.readUTF();
                this.@event.numPeople = param1.readInt();
                this.@event.ownerUserCode = param1.readUTF();
                this.@event.ownerName = param1.readUTF();
                this.@event.dataType = param1.readUTF();
                this.@event.publishing = param1.readByte();
                this.@event.likeEnabled = param1.readBoolean();
            }
      
        }

        public void writeData(AmebaStream Out)
        {
           
            return;
        }
    }
}

