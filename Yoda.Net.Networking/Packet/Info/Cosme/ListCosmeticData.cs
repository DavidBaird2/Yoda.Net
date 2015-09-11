namespace Yoda.Net.Networking.Packet.Info.Cosme
{
    
    
    using System;
    using System.Collections;

    public class ListCosmeticData  : ICommandData
    {
        public ListCosmeticData()
        {
        }
   
        public int packetId
        {
            get
            {
                return PacketId.LIST_COSMETIC;
            }
        }
      
        public void readData(PiggStream In)
        {
            return;
        }

        public void writeData(PiggStream Out)
        {
         
            return;
        }

    }
}

