namespace Yoda.Net.Networking.Packet.Info.ActionItem
{
    using System;
    using System.Collections;
    using Yoda.Net.Networking.Data.Common;
    public class ListUserActionItemResultData : ICommandData
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

        public void readData(PiggStream In)
        {
            UserActionItemData useractiondata = null;
            this.max = In.readInt();
            int num = In.readInt();
            this.list = new ArrayList(num);
            var i = 0;
            while (i < num)
            {
                useractiondata = new UserActionItemData();
                useractiondata.readData(In);
                this.list.Add(useractiondata);
                i++;
            }
        }

        public void writeData(PiggStream Out)
        {

            throw new NotImplementedException();
        }
    }
}

