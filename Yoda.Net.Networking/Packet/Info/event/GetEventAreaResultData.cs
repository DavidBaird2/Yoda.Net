namespace Yoda.Net.Networking.Packet.Info.Event
{


    using Yoda.Net.Networking.Packet.Data.Event;
    using System;
    using System.Collections;
    using Yoda.Net.Networking.Data.Event;

    public class GetEventAreaResultData : ICommandData
    {
        public EventData @event;
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
        public void readData(PiggStream stream)
        {
            this.@event = new EventData();
            this.myEventCondition = stream.readInt();
            this.isSeen = stream.readBoolean();
            this.myEventTitle = stream.readUTF();
            this.@event.roomEventCondition = stream.readBoolean();
            if (this.@event.roomEventCondition)
            {
                this.@event.areaCategory = stream.readUTF();
                this.@event.areaCode = stream.readUTF();
                this.@event.areaTitle = stream.readUTF();
                this.@event.category = stream.readUTF();
                this.@event.title = stream.readUTF();
                this.@event.description = stream.readUTF();
                this.@event.createTime = stream.readDouble();
                this.@event.image = stream.readBoolean();
                this.@event.originPath = stream.readUTF();
                this.@event.thumbPath = stream.readUTF();
                this.@event.numPeople = stream.readInt();
                this.@event.ownerUserCode = stream.readUTF();
                this.@event.ownerName = stream.readUTF();
                this.@event.dataType = stream.readUTF();
                this.@event.publishing = stream.readByte();
                this.@event.likeEnabled = stream.readBoolean();
            }

        }

        public void writeData(PiggStream Out)
        {

            throw new NotImplementedException();
        }
    }
}

