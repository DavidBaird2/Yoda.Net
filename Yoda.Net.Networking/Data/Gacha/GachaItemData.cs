using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking.Data.Common;

namespace Yoda.Net.Networking.Data.Gacha
{
    public class GachaItemData
    {
        public GachaItemData()
        {

            this.code = "";
            this.type = "";
            this.name = "";
            this.quantity = 0;
        }

		public void readData(PiggStream In)
		{	
			ShopSetItemData setItemData = null;

			this.code = In.readUTF();
			this.type = In.readUTF();
			this.name = In.readUTF();
			this.rarity = In.readByte();
			this.quantity = In.readInt();
			this.setItemSize = In.readInt();

            if (this.setItemSize > 0)
            {
                this.setItemData = new List<ShopSetItemData>();
               

                this.setItemSize.Times(() =>
                {
                    setItemData = new ShopSetItemData();
                    setItemData.readData(In);
                    this.setItemData.Add(setItemData);

                });
            }
		}

		public void writeData(PiggStream Out)
		{
            throw new NotImplementedException();
		}

        public string type { get; set; }

        public string code { get; set; }

        public string name { get; set; }

        public sbyte rarity { get; set; }

        public int quantity { get; set; }

        public int setItemSize { get; set; }

        public List<ShopSetItemData> setItemData { get; set; }
    }
}
