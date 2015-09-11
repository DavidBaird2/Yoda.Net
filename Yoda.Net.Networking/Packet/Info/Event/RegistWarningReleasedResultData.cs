namespace Yoda.Net.Networking.Packet.Info.Event
{


    using Yoda.Net.Networking.Packet.Data.Event;
    using System;
    using System.Collections;
    using Yoda.Net.Networking.Data.Event;

    public class RegistWarningReleasedResultData   : ICommandData
    {
      
        public int packetId
        {
            get
            {
                return PacketId.AGREE_NOTICE_BOARD_PENALTY_RESULT;
            }
        }
       
        public void readData(PiggStream In)
        {
            this.success = In.readBoolean();

        }

        public void writeData(PiggStream Out)
        {
            Out.writeBoolean(success);
         
        }


        public bool success { get; set; }
    }
}

