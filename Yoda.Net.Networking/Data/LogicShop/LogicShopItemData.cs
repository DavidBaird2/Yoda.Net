using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Networking.Data.Common;

namespace Yoda.Net.Networking.Data.LogicShop
{
    public class LogicShopItemData : ShopItemData
    {




        override public void readData(PiggStream In, bool hasItemType = false)
		{
	
			ShopSetItemData shipSetItemData = null;


			type = In.readUTF();
			itemId = In.readUTF();
			name = In.readUTF();
			quantity = In.readInt();
			description = In.readUTF();
			orderNum = In.readInt();
			newItem = In.readBoolean();
			setItemSize = In.readInt();

			if(setItemSize > 0){
                setItemSize.Times(() =>
                {
                    shipSetItemData = new ShopSetItemData();
                    shipSetItemData.readData(In, hasItemType);
                    setItemData.Add(shipSetItemData);

                  
                });
			}

			var shopPriceCount = In.readByte();

			this.shopPrice = new List<LogicShopPrice>(shopPriceCount);
            shopPriceCount.Times(() =>
            {
               var  logicShopPrice = new LogicShopPrice();
                logicShopPrice.readData(In);

                this.shopPrice.Add(logicShopPrice);
             
            });
		}


        public List<LogicShopPrice> shopPrice { get; set; }
    }
}
