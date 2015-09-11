namespace Yoda.Net.Networking.Packet.Info.Event
{


    using System;
    using System.Collections;
    using Yoda.Net.Networking.Data.Event;

    public class UpdateEventData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.UPDATE_NOTICE_BOARD_MESSAGE;
            }
        }

        public void readData(PiggStream In)
        {
            this.category = In.readUTF();
            this.title = In.readUTF();
            this.description = In.readUTF();
            isNotified = In.readBoolean();
            this.publishing = In.readByte();
        }

        public void writeData(PiggStream Out)
        {
          
            Out.writeUTF(this.category);
            Out.writeUTF(this.title);
            Out.writeUTF(this.description);
            Out.writeBoolean(this.isNotified);
            Out.writeByte(this.publishing);
        }





        public string category { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public bool isNotified { get; set; }

        public sbyte publishing { get; set; }
    }
}

