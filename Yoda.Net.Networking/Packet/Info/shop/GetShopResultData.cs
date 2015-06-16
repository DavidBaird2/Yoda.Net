
namespace Yoda.Net.Networking.Packet.Info.area
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    
    using Yoda.Net.Networking.Packet.Data.common;
    using System.Collections;

    public class GetShopResultData : IPacket
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
        public void readData(AmebaStream In)
        {
            ShopItemData _loc_4 = null;
            ShopAnnounceData _loc_5 = null;
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
            var _loc_2 = 0;
            while (_loc_2 < shop.itemsCount)
            {

                _loc_4 = new ShopItemData();
                _loc_4.readData(In);
                shop.itemsArray.Insert(_loc_2, _loc_4);
                _loc_2++;

            }
            int count = In.readInt();
            /*announceList = new ArrayList(count);
            _loc_2 = 0;
            while (_loc_2 < count)
            {

                _loc_5 = new ShopAnnounceData();
                _loc_5.title = In.readUTF();
                _loc_5.link = In.readUTF();
                _loc_5.time = DateTime.Parse("1970/1/1 09:00").AddMilliseconds(In.readDouble());
                announceList.Insert(_loc_2, _loc_5);
                _loc_2++;
            }*/
            /*int gachaCount = In.readInt();
            this.gachaList = new ArrayList(gachaCount);
            _loc_2 = 0;
            return;*/
            //while (_loc_2 < gachaCount)
            //  {

            //            var _loc_6 = new ShopGachaData();
            //  //            _loc_6.readData(In);
            //            this.gachaList.Insert(_loc_2,_loc_6);
            //     _loc_2++;
            //    }
            /*  this.shop.gachaList = this.gachaList;
              gender = In.readByte();
              bodyPart = new BodyPartData();
              bodyPart.gender = (short)gender;
              bodyColor = new BodyColorData();
              bodyPosition = new BodyPositionData();
              bodyItem = new BodyItemData();
              bodyPart.readData(In);
              bodyColor.readData(In);
              bodyPosition.readData(In);
              var _loc_3 = In.readByte();
              bodyItem.items = new ArrayList(_loc_3);
              _loc_2 = 0;
              while (_loc_2 < _loc_3)
              {

                  bodyItem.items.Insert(_loc_2, In.readUTF());
                  _loc_2++;
              }
              shop.userCode = In.readUTF();
              if (shop.userCode == NO_USER)
              {
                  shop.userCode = null;
              }
              return;*/
        }

        public void writeData(AmebaStream Out)
        {
            /*{


                Out.writeBoolean(shop.giftActive);
                Out.writeInt(shop.shopType);
                Out.writeInt(point);
                Out.writeInt(gold);
                Out.writeInt(coupon);
                Out.writeUTF(shop.shopCode);
                Out.writeUTF(shop.name);
                Out.writeUTF(shop.staffDescription);
                Out.writeUTF(shop.staffDescription2);
                Out.writeUTF(shop.shopTemplateCode);
                Out.writeInt(shop.itemsCount);
                foreach (ShopItemData _loc_4 in shop.itemsArray)
                {

                    Out.writeUTF(_loc_4.shelf);
                    Out.writeUTF(_loc_4.type);
                    Out.writeUTF(_loc_4.category);
                    Out.writeUTF(_loc_4.itemId);
                    Out.writeUTF(_loc_4.name);
                    Out.writeUTF(_loc_4.description);
                    Out.writeInt(_loc_4.price);
                    Out.writeInt(_loc_4.stock);
                    Out.writeDouble(_loc_4.time.Subtract(DateTime.Parse("1970/1/1 09:00")).TotalMilliseconds);
                    Out.writeInt(_loc_4.orderNum);
                    Out.writeInt(_loc_4.quantity);
                    Out.writeBoolean(_loc_4.newItem);
                    Out.writeBoolean(_loc_4.disableCoupon);
                    Out.writeBoolean(_loc_4.countLimited);
                    Out.writeBoolean(_loc_4.termLimited);
                    Out.writeBoolean(_loc_4.again);
                    Out.writeBoolean(_loc_4.recommended);
                    Out.writeBoolean(_loc_4.sale);
                    Out.writeBoolean(_loc_4.topRecommended);
                    Out.writeBoolean(_loc_4.maleOnly);
                    Out.writeBoolean(_loc_4.femaleOnly);
                    Out.writeBoolean(_loc_4.isGiftItem);
                    // Out.writeBoolean(true);
                 //   Out.writeByte((byte)_loc_4.isGiftItemOnly);
                    Out.writeBoolean(_loc_4.isRequirementMet);
                    Out.writeBoolean(_loc_4.isForOppositeGender);
                }
                Out.writeInt(announceList.Count);
                foreach (ShopAnnounceData _loc_5 in announceList)
                {
                    Out.writeUTF(_loc_5.title);
                    Out.writeUTF(_loc_5.link);
                    Out.writeDouble(_loc_5.time.Subtract(DateTime.Parse("1970/1/1 09:00")).TotalMilliseconds);
                    //    Out.writeDouble(_loc_5.time. = DateTime.Parse("1970/1/1 09:00").AddMilliseconds(In.readDouble());
                }
                Out.writeByte((byte)gender);

                bodyPart.writeData(Out);
                bodyColor.writeData(Out);
                bodyPosition.writeData(Out);
                Out.writeByte((byte)bodyItem.items.Count);

                foreach (string item in bodyItem.items)
                {
                    Out.writeUTF(item);
                }
                if (shop.userCode == null)
                {
                    Out.writeUTF(NO_USER);
                }
                else
                {
                    Out.writeUTF(shop.userCode);
                }
                return;
            
            }*/
        }
    }
}

