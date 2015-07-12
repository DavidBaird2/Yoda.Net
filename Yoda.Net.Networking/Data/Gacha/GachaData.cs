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
         public void readData(PiggStream stream)
        {
            throw new NotImplementedException();
        }

    }
}
