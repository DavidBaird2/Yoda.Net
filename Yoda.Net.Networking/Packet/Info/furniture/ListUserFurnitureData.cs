namespace Yoda.Net.Networking.Packet.Info.furuniture
{
    

    using System;
    using System.Collections;
    
    public class ListUserFurnitureData : ICommandData
    {


        public int packetId
        {
            get
            {
                return PacketId.LIST_USER_FURNITURE;
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

