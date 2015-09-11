namespace Yoda.Net.Networking.Packet.Info.Event
{


    using Yoda.Net.Networking.Packet.Data.Event;
    using System;
    using System.Collections;
    using Yoda.Net.Networking.Data.Event;

    public class RegistWarningReleasedData : ICommandData
    {
      
        public int packetId
        {
            get
            {
                return PacketId.AGREE_NOTICE_BOARD_PENALTY;
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

