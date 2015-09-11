namespace Yoda.Net.Networking.Packet.Info.ActionItem
{
    
    
    using System;
    using System.Collections;
    public class ListUserActionItemData : ICommandData
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

