namespace Yoda.Net.Networking.Packet.Info.actionitem
{
    using Yoda.Net.Networking.Packet.Data.common;
    
    
    using System;
    using System.Collections;
    using Yoda.Net.Networking.Data.Common;
    public class ListUserActionItemResultData : IPacket
    {
        public ArrayList list;
        public int max;
        public ListUserActionItemResultData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.LIST_USER_ACTION_ITEM_RESULT;
            }
        }

        public void readData(AmebaStream param1)
        {
            UserActionItemData _loc4_ = null;
            this.max = param1.readInt();
            int _loc2_ = param1.readInt();
            this.list = new ArrayList(_loc2_);
            var _loc3_ = 0;
            while (_loc3_ < _loc2_)
            {
                _loc4_ = new UserActionItemData();
                _loc4_.readData(param1);
                this.list.Add(_loc4_);
                _loc3_++;
            }
        }

        public void writeData(AmebaStream Out)
        {

            return;
        }
    }
}

