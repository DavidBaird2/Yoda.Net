
namespace Yoda.Net.Networking.Packet.Info.Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    
    using System.Collections;
    using Yoda.Net.Networking.Data.Common;
    using Yoda.Net.Networking.Data.Cosme;

    public class GetShopResultData : ICommandData
    {
        
       private static string NO_USER = "8874e43a01f8105e";
        public int packetId
        {
            get
            {
                return PacketId.GET_SHOP_RESULT;
            }
        }
        public GetShopResultData()
        {
            return;
        }
        public void readData(PiggStream In)
        {
       ShopItemData shopItemData = null;
			CosmeDressUpItemData cduid = null;

			this.shop = new ShopData();
			this.shop.shopType = In.readInt();
			this.zone = In.readByte();

			if(this.zone == 0) this.zone = 1;

			this.shop.zone = this.zone;
			this.point = In.readInt();
			this.coin = In.readInt();
			this.coupon = In.readInt();
			this.shop.shopCode = In.readUTF();
			this.shop.name = In.readUTF();
			this.shop.staffDescription = In.readUTF();
			this.shop.staffDescription2 = In.readUTF();
			this.shop.shopTemplateCode = In.readUTF();

			bool isAmeShop = (this.shop.shopType == ShopData.AME_SHOP);

			this.shop.itemsCount = In.readInt();
			this.shop.items = new List<ShopItemData>(this.shop.itemsCount);

			this.shop.itemsCount.Times(()=>{
				shopItemData = new ShopItemData();
				shopItemData.readData(In);

				shopItemData.isAmeShop = isAmeShop;
				this.shop.items.Add( shopItemData);
			
			});

			this.shop.gender = In.readByte();
			this.bodyPart = new BodyPartData();
			this.bodyPart.readData(In);

			this.bodyPart.gender = (sbyte)this.shop.gender;
			this.bodyColor = new BodyColorData();
			this.bodyColor.readData(In);

			this.bodyPosition = new BodyPositionData();
			this.bodyPosition.readData(In);

			this.bodyItem = new BodyItemData();

            int bodyItemCount = In.readByte();

			this.bodyItem.items = new List<string>(bodyItemCount);
            bodyItemCount.Times(() =>
            {
                this.bodyItem.items.Add(In.readUTF());
         
            });

			int bodyCosmeCount = In.readByte();
            this.bodyCosme = new List<CosmeDressUpItemData>(bodyCosmeCount);


            bodyCosmeCount.Times(() =>
            {
                cduid = new CosmeDressUpItemData();
                cduid.readData(In);

                this.bodyCosme.Add(cduid);
                
            });

			this.shop.coinBannerLinkInfo.readData(In);

			this.shop.openPanelInfo = In.readUTF();
		}
        public void writeData(PiggStream Out)
        {

            throw new NotImplementedException();
        }

        public ShopData shop { get; set; }

        public sbyte zone { get; set; }

        public int point { get; set; }

        public int coin { get; set; }

        public int coupon { get; set; }

        public BodyPartData bodyPart { get; set; }

        public BodyColorData bodyColor { get; set; }

        public BodyPositionData bodyPosition { get; set; }

        public BodyItemData bodyItem { get; set; }

        public List<CosmeDressUpItemData> bodyCosme { get; set; }
    }
}

