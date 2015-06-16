namespace Yoda.Net.Networking.Packet.Info.item
{
    
    using System;
    
    using System.Collections;
    using Yoda.Net.Networking.Packet.Data.common;

    public class ListUserItemData : IPacket
    {

        public int packetId
        {
            get
            {
                return PacketId.LIST_USER_ITEM;
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

