namespace Yoda.Net.Networking.Packet.Info.item
{
    
    
    using Yoda.Net.Networking.Packet.Info;
    using System.Collections;
    using System;

    public class ListScratchData : IPacket
    {

        public int packetId
        {
            get
            {
                return PacketId.LIST_SCRATCH;
            }
        }
        public ListScratchData()
        {
            return;
        }
        public void readData(AmebaStream In)
        {
            return;
        }

        public void writeData(AmebaStream Out)
        {

            return;
        }
    }
}

