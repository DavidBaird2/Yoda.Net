namespace Yoda.Net.Networking.Packet.Info.Event
{


    using Yoda.Net.Networking.Packet.Data.Event;
    using System;
    using System.Collections;
    using Yoda.Net.Networking.Data.Event;

    public class CreateEventResultData  : ICommandData
    {
      
        public int packetId
        {
            get
            {
                return PacketId.CREATE_NOTICE_BOARD_MESSAGE_RESULT;
            }
        }
        public CreateEventResultData()
        {

        }
        public void readData(PiggStream In)
        {
            if (this.isSuccess = In.readBoolean())
            {
                this.eventTitle = In.readUTF();
                this.defaultEnterRoom = In.readByte();
            }

        }

        public void writeData(PiggStream Out)
        {

            throw new NotImplementedException();
        }

        public bool isSuccess { get; set; }

        public string eventTitle { get; set; }

        public sbyte defaultEnterRoom { get; set; }
    }
}

