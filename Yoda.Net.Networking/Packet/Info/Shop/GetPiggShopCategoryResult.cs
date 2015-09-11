
namespace Yoda.Net.Networking.Packet.Info.Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Yoda.Net.Networking.Data.Common;



    public class GetPiggShopCategoryResult : ICommandData
    {
        public GetPiggShopCategoryResult()
        {
        }


        public int packetId
        {
            get
            {
                return PacketId.GET_PIGGSHOP_CATEGORY_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            ShopItemData shopItemData = null;

            this.type = In.readUTF();
            this.category = In.readUTF();

            bool isAmeShop = ((this.type == "ame") || (this.category == "gift_ame_item"));
            bool isGiftOnly = (this.type == "gift");
            var count = In.readInt();

            this.items = new List<ShopItemData>(count);

            count.Times(() =>
            {
                shopItemData = new ShopItemData();
                shopItemData.isAmeShop = isAmeShop;
                shopItemData.isGiftOnly = isGiftOnly;
                shopItemData.readData(In, true);

                this.items.Add(shopItemData);

            });
        }

        public void writeData(PiggStream Out)
        {

            throw new NotImplementedException();
        }

        public string type { get; set; }

        public string category { get; set; }

        public List<ShopItemData> items { get; set; }
    }
}

