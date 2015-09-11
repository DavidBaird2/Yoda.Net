namespace Yoda.Net.Networking.Packet.Info.Event
{


    using System;
    using System.Collections;
    using Yoda.Net.Networking.Data.Event;

    public class UpdateEventResultData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.UPDATE_NOTICE_BOARD_MESSAGE_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            this._event = new EventData();
            this._event.category = In.readUTF();
            this._event.title = In.readUTF();
            this._event.description = In.readUTF();
            this._event.publishing = In.readByte();
        }

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
           
        }




        public EventData _event { get; set; }
    }
}

