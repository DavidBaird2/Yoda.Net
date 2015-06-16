namespace Yoda.Net.Networking.Data.Common
{
    using System;
    using System.Collections;

    public class ShopData
    {
        public string shopCode;
        public string name;
        public int shopType;
        public string userCode;
        public string shopTemplateCode;
        public bool giftActive;
        public int itemsCount;
   //     public var shopTemplateDomain:ApplicationDomain;
        public string staffDescription2;
        public string areaName;
        public ArrayList gachaList;
        public ArrayList itemsArray;
        public string staffDescription;
        public const int CASINO_SHOP = 3;
        public const int FISHING_BARTER = 4;
        public const int GOLD_SHOP = 0;
        public const int AME_SHOP = 1;
        public const int FISH_SHOP = 2;
        public ShopData()
        {
        }
    }
}

