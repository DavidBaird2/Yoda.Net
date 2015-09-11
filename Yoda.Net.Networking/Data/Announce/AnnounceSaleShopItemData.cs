using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoda.Net.Networking.Data.Announce
{
    public class AnnounceSaleShopItemData
    {
        public void readData(PiggStream In)
        {
            this.type = In.readUTF();
            this.code = In.readUTF();
            this.name = In.readUTF();
            this.description = In.readUTF();
            this.basePrice = In.readInt();
            this.salePrice = In.readInt();
        }

        public string type { get; set; }

        public string code { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public int basePrice { get; set; }

        public int salePrice { get; set; }
    }
}
