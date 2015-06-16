namespace Yoda.Net.Networking.Packet.Info.actionitem
{
    
    
    using System;
    using System.Collections;
    public class ListUserActionItemData : IPacket
    {
        public ArrayList list;
        public ListUserActionItemData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.LIST_USER_ACTION_ITEM;
            }
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

