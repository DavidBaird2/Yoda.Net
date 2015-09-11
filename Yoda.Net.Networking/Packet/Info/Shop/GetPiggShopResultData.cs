
namespace Yoda.Net.Networking.Packet.Info.Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Yoda.Net.Networking.Data.Common;
    using Yoda.Net.Networking.Data.Cosme;



    public class GetPiggShopResultData : ICommandData
    {
        public GetPiggShopResultData()
        {
        }

        private static string NO_USER = "8874e43a01f8105e";

        public int packetId
        {
            get
            {
                return PacketId.GET_PIGGSHOP_RESULT;
            }
        }

        public void readData(PiggStream In)
        {

            this.shop = new PiggShopData();
            this.shop.shopCode = "pigg";
            this.shop.shopType = ShopData.COIN_SHOP;
            this.zone = In.readByte();

            if (this.zone == 0) this.zone = 1;

            this.shop.zone = this.zone;
            this.point = In.readInt();
            this.coin = In.readInt();
            this.coupon = In.readInt();
            this.shop.newsClipData.title = In.readUTF();
            this.shop.newsClipData.category = In.readUTF();
            this.shop.newsClipData.type = In.readUTF();
            this.shop.newsClipData.url = In.readUTF();
            this.shop.newsClipData.iconKind = In.readInt();
            this.shop.saleInfoData.noticeMessage = In.readUTF();
            this.shop.saleInfoData.remainTime = In.readTime();
            this.shop.saleInfoData.seriesCode = In.readUTF();

            var bannerCount = In.readInt();

            this.shop.banners = new List<ShopBannerData>(bannerCount);

            bannerCount.Times(() =>
            {
                var bannerData = new ShopBannerData();
                bannerData.readData(In);

                shop.banners.Add(bannerData);

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
            bannerCount = In.readByte();
            this.bodyItem.items = new List<string>();
            bannerCount.Times(() =>
            {
                this.bodyItem.items.Add(In.readUTF());

            });

            bannerCount = In.readByte();
            this.bodyCosme = new List<CosmeDressUpItemData>();

            bannerCount.Times(() =>
            {
                var cosmeDressupItemData = new CosmeDressUpItemData();
                cosmeDressupItemData.readData(In);

                this.bodyCosme.Add(cosmeDressupItemData);

            });

            this.shop.userCode = In.readUTF();

            if (this.shop.userCode == NO_USER) this.shop.userCode = null;

            this.shop.userGender = In.readByte();
            this.shop.coinBannerLinkInfo.readData(In);
            this.shop.vipShopStatus.readData(In);
        }

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();

        }





        public PiggShopData shop { get; set; }

        public BodyPartData bodyPart { get; set; }

        public BodyColorData bodyColor { get; set; }

        public BodyPositionData bodyPosition { get; set; }

        public BodyItemData bodyItem { get; set; }

        public List<CosmeDressUpItemData> bodyCosme { get; set; }

        public sbyte zone { get; set; }
        public int point { get; set; }
        public int coin { get; set; }
        public int coupon { get; set; }
    }
}

