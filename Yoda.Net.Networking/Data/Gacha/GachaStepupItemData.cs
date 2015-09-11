using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoda.Net.Networking.Data.Gacha
{
    public class GachaStepupItemData
    {
        public int quantity;
        public string itemCode;
        public string itemName;
        public string itemType;

        public GachaStepupItemData(int quantity, string itemCode, string itemName, string itemType)
        {
            // TODO: Complete member initialization
            this.quantity = quantity;
            this.itemCode = itemCode;
            this.itemName = itemName;
            this.itemType = itemType;
        }
    }
}
