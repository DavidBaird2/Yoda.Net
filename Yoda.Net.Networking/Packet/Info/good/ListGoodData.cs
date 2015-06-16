namespace Yoda.Net.Networking.Packet.Info.item
{
    
    
    using Yoda.Net.Networking.Packet.Info;
    using System.Collections;

    using System;

    public class ListGoodData : IPacket
    {

        public int packetId
        {
            get
            {
                return PacketId.LIST_GOOD;
            }
        }
        public ListGoodData()
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

