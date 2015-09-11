namespace Yoda.Net.Networking.Packet.Info.Event
{


    using System;
    using System.Collections;
    using Yoda.Net.Networking.Data.Event;

    public class DeleteEventResultData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.DELETE_NOTICE_BOARD_MESSAGE_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
         
        }

        public void writeData(PiggStream Out)
        {
          
           
        }




    }
}

