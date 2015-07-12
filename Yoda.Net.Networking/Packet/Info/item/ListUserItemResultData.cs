namespace Yoda.Net.Networking.Packet.Info.item
{

    using System;
    using System.Collections;
    using Yoda.Net.Networking.Data.Common;
    public class ListUserItemResultData : ICommandData
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

        public void readData(PiggStream In)
        {
   
            max = In.readInt();
            var count = In.readInt();
            items = new ArrayList(count);
            var i = 0;
            while (i < count)
            {

                UserItemData uid = new UserItemData();
                uid.readData(In);
                items.Insert(i, uid);
                i++;
            }
        }

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
        }
    }
}

