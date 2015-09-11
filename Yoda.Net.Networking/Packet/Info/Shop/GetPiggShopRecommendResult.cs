
namespace Yoda.Net.Networking.Packet.Info.Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Yoda.Net.Networking.Data.Common;



    public class  GetPiggShopRecommendResult  : ICommandData
    {
        public GetPiggShopRecommendResult()
        {
        }
   

        public int packetId
        {
            get
            {
                return PacketId.GET_PIGGSHOP_RECOMMEND_RESULT; 
            }
        }
       
        public void readData(PiggStream In)
        {
         	ShopBannerData  bannerData = null;

			this.type = In.readUTF();
			this.category = In.readUTF();

			var count = In.readInt();

			this.items = new List<ShopBannerData>(count);

            count.Times(() =>
            {
                bannerData = new ShopBannerData();
                bannerData.readData(In);

                this.items.Add(bannerData);
               
            });
        }

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();

        }


        public string type { get; set; }

        public string category { get; set; }

        public List<ShopBannerData> items { get; set; }
    }
}

