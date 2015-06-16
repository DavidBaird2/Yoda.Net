namespace Yoda.Net.Networking.Packet.Info.furuniture
{
    

    using System;
    using System.Collections;
    
    using Yoda.Net.Networking.Packet.Data.room;

    public class ListUserFurnitureData : IPacket
    {


        public int packetId
        {
            get
            {
                return PacketId.LIST_USER_FURNITURE;
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

