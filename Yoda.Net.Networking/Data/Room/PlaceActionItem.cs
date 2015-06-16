namespace Yoda.Net.Networking.Data.Room
{
    using System;

    public class PlaceActionItem
    {
        public string itemCode;
        public string itemType;
        public string ownerCode;
         public int actionItemType = 2;
        public int sequence;
        public short x;
        public short y;
        public short z;

        public PlaceActionItem clone()
        {
            return new PlaceActionItem { itemCode = this.itemCode, itemType = this.itemType, sequence = this.sequence, ownerCode = this.ownerCode, x = this.x, y = this.y, z = this.z };
        }
    }
}

