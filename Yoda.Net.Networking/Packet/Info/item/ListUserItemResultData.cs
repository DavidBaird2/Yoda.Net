namespace Yoda.Net.Networking.Packet.Info.item
{
    
    using System;
    
    using System.Collections;
    using Yoda.Net.Networking.Packet.Data.common;

    public class ListUserItemResultData : IPacket
    {
        public int max;
        public ArrayList items;

        public int packetId
        {
            get
            {
                return PacketId.LIST_USER_ITEM_RESULT;
            }
        }

        public void readData(AmebaStream In)
        {
            UserItemData _loc_4 = null;
            max = In.readInt();
            var _loc_2 = In.readInt();
            items = new ArrayList(_loc_2);
            var _loc_3 = 0;
            while (_loc_3 < _loc_2)
            {
                
                _loc_4 = new UserItemData();
                _loc_4.readData(In);
                items.Insert(_loc_3, _loc_4);
                _loc_3++;
            }
        }

        public void writeData(AmebaStream Out)
        {

        }
    }
}

