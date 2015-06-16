using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace Yoda.Net.Networking.Data.Gacha
{
    public class GachaData
    {
        public int payType;
        public bool isDisEnableCoupon;
        public int listSize;
        public int price;
        public string name;
        public int genderCode;
        public int couponQuantiry;
        public int remainingFreePlayCount;
        public ArrayList incentiveItemList;
        public string campaignCode;
        public bool isEnableDarts;
        public string infoUrl;
        public ArrayList incentiveThreeItemList;
        public string code;
        public string description2;
        public ArrayList featuredItems;
        public string template;
        public int playCount;
        public string description;
        public static int PAY_TYPE_FISHING = 3;
        public static int PAY_TYPE_COUPON = 2;
        public static int PAY_TYPE_GOLD = 0;
        public static int PAY_TYPE_CANDY = 1;
        public static int PAY_TYPE_CASINO = 4;
         public void readData(AmebaStream param1)
        {
          /*  int _loc_2: = 0;
            var _loc_4:CollectionCampaignIncentiveItemData = null;
            var _loc_5:CollectionCampaignIncentiveItemData = null;
            var _loc_6:GachaItemData = null;*/
            code = param1.readUTF();
            name = param1.readUTF();
            payType = param1.readByte();
            price = param1.readInt();
            description = param1.readUTF();
            description2 = param1.readUTF();
            template = param1.readUTF();
            infoUrl = param1.readUTF();
            remainingFreePlayCount = param1.readInt();
            campaignCode = param1.readUTF();
          /*  var _loc_3:* = param1.readInt();
            incentiveItemList = new Array(_loc_3);
            _loc_2 = 0;
            while (_loc_2 < _loc_3)
            {
                
                _loc_4 = new CollectionCampaignIncentiveItemData();
                _loc_4.itemName = param1.readUTF();
                _loc_4.itemCode = param1.readUTF();
                _loc_4.itemType = param1.readUTF();
                _loc_4.isProvided = param1.readBoolean();
                incentiveItemList[_loc_2] = _loc_4;
                _loc_2++;
            }
            _loc_3 = param1.readInt();
            incentiveThreeItemList = new Array(_loc_3);
            _loc_2 = 0;
            while (_loc_2 < _loc_3)
            {
                
                _loc_5 = new CollectionCampaignIncentiveItemData();
                _loc_5.itemName = param1.readUTF();
                _loc_5.itemCode = param1.readUTF();
                _loc_5.itemType = param1.readUTF();
                _loc_5.isProvided = param1.readBoolean();
                incentiveThreeItemList[_loc_2] = _loc_5;
                _loc_2++;
            }
            featuredItems = new Array(param1.readInt());
            _loc_2 = 0;
            while (_loc_2 < featuredItems.length)
            {
                
                _loc_6 = new GachaItemData();
                _loc_6.readData(param1);
                featuredItems[_loc_2] = _loc_6;
                _loc_2++;
            }*/
            return;
        }

    }
}
