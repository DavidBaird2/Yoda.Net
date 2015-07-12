namespace Yoda.Net.Networking.Packet.Info.footprint
{
    
    
    using System;
    using System.Collections;
    public class ListFootPrintData : ICommandData
    {

        public ListFootPrintData()
        {
        }
        public int packetId
        {
            get
            {
                return PacketId.LIST_FOOTPRINT;
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

