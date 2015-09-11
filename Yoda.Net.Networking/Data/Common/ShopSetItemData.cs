using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Common
{
    public  class ShopSetItemData
    {
        public void readData(PiggStream In, Boolean hasItemType = false)
        {	
            this.itemCode = In.readUTF();
            this.itemCategory = In.readUTF();
            this.itemName = In.readUTF();
            this.itemQuantity = In.readInt();

            if (hasItemType) this.itemType = In.readUTF();
        }

        public string itemCode { get; set; }

        public string itemCategory { get; set; }

        public string itemName { get; set; }

        public int itemQuantity { get; set; }

        public string itemType { get; set; }
    }
}
