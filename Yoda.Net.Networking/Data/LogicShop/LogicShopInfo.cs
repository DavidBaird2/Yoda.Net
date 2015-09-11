using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.LogicShop
{
    public  class LogicShopInfo
    {
        	
		public string shopCode;                                     
		public string name;                                         
		public string staffDescription;                             
		public string staffDescription2;                            
		public string shopTemplateCode;                             
		public List<LogicShopData> shops;                        
		public List<LogicShopItemData> items;                    
        public List<LogicUserPoint> userPoint;                  

		public void readData(PiggStream In)
		{
            LogicShopData logicShopData = null;
			LogicShopItemData logicShopItemData = null;

			LogicUserPoint logicUserPoint = null;

			this.shopCode = In.readUTF();
			this.name = In.readUTF();
			this.shopTemplateCode = In.readUTF();
			this.staffDescription = In.readUTF();
			this.staffDescription2 = In.readUTF();

			int shopCount = In.readByte();

			this.shops = new List<LogicShopData>(shopCount);

            shopCount.Times(() =>
            {
                logicShopData = new LogicShopData();
                logicShopData.readData(In);

                this.shops.Add(logicShopData);
             
            });

			shopCount = In.readInt();
			this.items = new List<LogicShopItemData>(shopCount);
            shopCount.Times(() =>
           {
               logicShopItemData = new LogicShopItemData();
               logicShopItemData.readData(In);

               foreach (var shopPrice in logicShopItemData.shopPrice)
               {
                   if (logicShopData == this.getShop(shopPrice.shopCode)) shopPrice.shopType = logicShopData.shopType;
               }

               this.items.Add(logicShopItemData);
               
           }
           );
			shopCount = In.readByte();
			this.userPoint = new List<LogicUserPoint>(shopCount);
            shopCount.Times(() =>
            {
                logicUserPoint = new LogicUserPoint();
                logicUserPoint.readData(In);

                this.userPoint.Add(logicUserPoint);
     
            });
		}

		public LogicShopData getShop(string shopCode)
		{	

			LogicShopData shopData = null;

			foreach(var data in this.shops){
				if(data.shopCode == shopCode){
					shopData = data;
					break;
				}
			}

			return shopData;
		}


    }
}
