
namespace Yoda.Net.Networking.Packet.Info.Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    
    using System.Collections;
    using Yoda.Net.Networking.Data.Common;

    public class GetShopResultData : ICommandData
    {
        public int gender;
        public int point;
        public BodyItemData bodyItem;
        public int gold;
        public BodyColorData bodyColor;
        public int coupon;
        public BodyPositionData bodyPosition;
        public ArrayList announceList;
        public BodyPartData bodyPart;
        public ShopData shop;
        public ArrayList gachaList;
      //  private static string NO_USER = "8874e43a01f8105e";
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
            //未実装
        
            shop = new ShopData();
            shop.shopType = In.readInt();
            In.readByte();
            point = In.readInt();
            gold = In.readInt();
            coupon = In.readInt();

            shop.shopCode = In.readUTF();
            shop.name = In.readUTF();
            shop.staffDescription = In.readUTF();
            shop.staffDescription2 = In.readUTF();
            shop.shopTemplateCode = In.readUTF();



            shop.itemsCount = In.readInt();
            shop.itemsArray = new ArrayList(shop.itemsCount);
            var i = 0;
            while (i < shop.itemsCount)
            {

                ShopItemData  sid = new ShopItemData();
                sid.readData(In);
                shop.itemsArray.Insert(i, sid);
                i++;

            }
            int count = In.readInt();
          
        }

        public void writeData(PiggStream Out)
        {

            throw new NotImplementedException();
        }
    }
}

