namespace Yoda.Net.Networking.Packet.Info.Event
{


    using Yoda.Net.Networking.Packet.Data.Event;
    using System;
    using System.Collections;
    using Yoda.Net.Networking.Data.Event;
    using System.Collections.Generic;

    public class SearchEventResultData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.SEARCH_NOTICE_BOARD_MESSAGE_RESULT;
            }
        }
        public SearchEventResultData()
        {

        }
        public void readData(PiggStream In)
        {
            EventData eventData = null;
            var count = In.readInt();

            this.events = new List<EventData>();

            var i = 0;

            while (i < count)
            {
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
                this.events.Add(eventData);

                i++;
            }

        }

        public void writeData(PiggStream Out)
        {

            throw new NotImplementedException();
        }



        public List<EventData> events { get; set; }
    }
}

