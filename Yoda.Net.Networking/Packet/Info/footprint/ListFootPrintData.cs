namespace Yoda.Net.Networking.Packet.Info.footprint
{
    
    
    using System;
    using System.Collections;
    public class ListFootPrintData : IPacket
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

        public void readData(AmebaStream In)
        {

         
        }

        public void writeData(AmebaStream Out)
        {
        }

    }
}

