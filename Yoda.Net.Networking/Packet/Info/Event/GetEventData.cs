namespace Yoda.Net.Networking.Packet.Info.Event
{
    
    
    using System;
    using System.Collections;

    public class GetEventData : ICommandData
    {
    
        public int packetId
        {
            get
            {
                return PacketId.GET_NOTICE_BOARD_MESSAGE;
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

