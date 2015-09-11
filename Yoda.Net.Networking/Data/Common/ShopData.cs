namespace Yoda.Net.Networking.Data.Common
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Yoda.Net.Networking.Data.Shop;

    public class ShopData
    {
        public string userCode;
        public int userGender;
        public string shopCode;
        public string name;
        public string staffDescription;
        public string staffDescription2;
        public string shopTemplateCode;

        public List<ShopItemData> items = new List<ShopItemData>();
        public int itemsCount;
        public int shopType;
        public string areaName;
        public int gender;
        public int zone;
        public bool isTutorial;
        public string actionCode;
        public ShopCoinBannerLinkInfo coinBannerLinkInfo = new ShopCoinBannerLinkInfo();
        public string openPanelInfo;
        public const int CASINO_SHOP = 3;
        public const int FISHING_BARTER = 4;
        public const int COIN_SHOP = 0;
        public const int AME_SHOP = 1;
        public const int FISH_SHOP = 2;
        public ShopData()
        {
        }
        public static string getPriceUnit(int type)
        {
            var result = "";

            switch (type)
            {
                case COIN_SHOP:
                    result = "コイン";
                    break;
                case AME_SHOP:
                    result = "アメ";
                    break;
                case CASINO_SHOP:
                    result = "カジノ";
                    break;
                case FISH_SHOP:
                    result = "つりP";
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}

