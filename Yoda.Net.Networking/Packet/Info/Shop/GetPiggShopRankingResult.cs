
namespace Yoda.Net.Networking.Packet.Info.Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Yoda.Net.Networking.Data.Common;



    public class GetPiggShopRankingResult : ICommandData
    {
        public GetPiggShopRankingResult()
        {
        }


        public int packetId
        {
            get
            {
                return PacketId.GET_PIGG_SHOP_ITEM_RANKING_RESULT;
            }
        }
      
        public void readData(PiggStream In)
        {
            ShopItemData shopItemData = null;

			this.type = In.readUTF();
			this.category = In.readUTF();
			this.termType = In.readByte();
			this.originId = In.readInt();

			var count = In.readInt();

			this.items = new List<ShopItemData>(count);

            count.Times(() =>
            {
                shopItemData = new ShopItemData();
                shopItemData.readData(In, true);

                this.items.Add(shopItemData);
                
            });
        }            

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
        }

        public List<ShopItemData> items { get; set; }

        public int originId { get; set; }

        public sbyte termType { get; set; }

        public string category { get; set; }

        public string type { get; set; }
    }
}

