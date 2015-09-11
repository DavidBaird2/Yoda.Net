
namespace Yoda.Net.Networking.Packet.Info.Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Yoda.Net.Networking.Data.Common;



    public class GetPiggShopSeriesResult : ICommandData
    {
        public GetPiggShopSeriesResult()
        {
        }


        public int packetId
        {
            get
            {
                return PacketId.GET_PIGGSHOP_SERIES_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            seriesCode = In.readUTF();
            seriesTypeCode = In.readUTF();

            ShopItemData ShopItemData = null;


            this.payType = In.readInt();

            bool isAmeShop = (this.payType == ShopData.AME_SHOP);
            int Count = In.readInt();

            this.items = new List<ShopItemData>(Count);


            Count.Times(() =>
            {
                ShopItemData = new ShopItemData();
                ShopItemData.readData(In, true);

                ShopItemData.seriesCode = this.seriesCode;
                ShopItemData.seriesTypeCode = this.seriesTypeCode;
                ShopItemData.isAmeShop = isAmeShop;
                this.items.Add(ShopItemData);

            });

            this.limitedBannerCode = In.readUTF();
        }

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();

        }





        public string seriesCode { get; set; }

        public string seriesTypeCode { get; set; }

        public List<ShopItemData> items { get; set; }

        public int payType { get; set; }

        public string limitedBannerCode { get; set; }
    }
}

