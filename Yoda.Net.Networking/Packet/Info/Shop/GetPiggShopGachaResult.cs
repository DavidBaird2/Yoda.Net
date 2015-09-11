
namespace Yoda.Net.Networking.Packet.Info.Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Yoda.Net.Networking.Data.Common;
    using Yoda.Net.Networking.Data.Gacha;



    public class GetPiggShopGachaResult : ICommandData
    {
        public GetPiggShopGachaResult()
        {
        }


        public int packetId
        {
            get
            {
                return PacketId.GET_PIGGSHOP_GACHA_RESULT;
            }
        }
      
        public void readData(PiggStream In)
        {
           ShopGachaData shopGachaData = null;

			this.type = In.readUTF();
			this.category = In.readUTF();

			int count = In.readInt();

			this.items = new List<ShopGachaData>(count);


            count.Times(() =>
            {
                shopGachaData = new ShopGachaData();
                shopGachaData.readData(In);

                this.items.Add(shopGachaData);
            });
        }            

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
        }





        public string type { get; set; }

        public string category { get; set; }

        public List<ShopGachaData> items { get; set; }
    }
}

