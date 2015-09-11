namespace Yoda.Net.Networking.Packet.Info.Event
{


    using Yoda.Net.Networking.Packet.Data.Event;
    using System;
    using System.Collections;
    using Yoda.Net.Networking.Data.Event;

    public class CreateEventData  : ICommandData
    {
      
        public int packetId
        {
            get
            {
                return PacketId.CREATE_NOTICE_BOARD_MESSAGE;
            }
        }
        public CreateEventData()
        {

        }
        public void readData(PiggStream In)
        {
            category = In.readUTF();
            title = In.readUTF();
            description = In.readUTF();
            isNotified = In.readBoolean();
            publishing = In.readByte();
            place = In.readByte();
        }

        public void writeData(PiggStream Out)
        {

            Out.writeUTF(this.category);
            Out.writeUTF(this.title);
            Out.writeUTF(this.description);
            Out.writeBoolean(this.isNotified);
            Out.writeByte(this.publishing);
            Out.writeByte(this.place);
        }



        public string category { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public bool isNotified { get; set; }

        public sbyte publishing { get; set; }

        public sbyte place { get; set; }
    }
}

