namespace Yoda.Net.Networking.Packet.Info.scratch
{
    
    
    using System;

    public class GetFortuneData : ICommandData
    {
  
        public int packetId
        {
            get
            {
                return PacketId.GET_FORTUNE;
            }
        }
        public GetFortuneData()
        {
          
            return;
        }

        public void readData(PiggStream In)
        {
      
        }

        public void writeData(PiggStream Out)
        {
       
            return;
        }
    }
}

