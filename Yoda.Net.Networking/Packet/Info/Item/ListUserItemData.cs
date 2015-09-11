namespace Yoda.Net.Networking.Packet.Info.Item
{
    
    using System;
    
    using System.Collections;

    public class ListUserItemData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.LIST_USER_ITEM;
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

