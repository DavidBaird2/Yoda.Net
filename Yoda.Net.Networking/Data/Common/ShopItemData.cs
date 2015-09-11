namespace Yoda.Net.Networking.Data.Common
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Yoda.Net.Networking;

    public class ShopItemData
    {
        public string shelf;
        public string type;
        public string category;
        public string itemId;
        public string name;
        public string description;
        public int price;
        public int originalPrice;
        public double remainTime;
        public int stock;
        public int setItemSize;
        public bool soldOut;
        public bool isForOppositeGender;
        public bool isRequirementMet;
        public bool isGiftOnly;
        public bool isGiftItem;
        public bool femaleOnly;
        public int orderNum;
        public int quantity;
        public bool newItem;
        public bool disableCoupon;
        public bool countLimited;
        public bool termLimited;
        public bool again;
        public bool recommended;
        public bool bargain;
        public bool sale;
        public bool maleOnly;



        public ShopItemData()
        {
            return;
        }

        public virtual void readData(PiggStream In, Boolean hasItemType = false)
        {
        

            this.shelf = In.readUTF();
            this.type = In.readUTF();
            this.category = In.readUTF();
            this.itemId = In.readUTF();
            this.name = In.readUTF();
            this.description = In.readUTF();
            this.price = In.readInt();
            this.originalPrice = In.readInt();
            this.remainTime = In.readDouble();
            this.stock = In.readInt();
            this.orderNum = In.readInt();
            this.quantity = In.readInt();
            this.newItem = In.readBoolean();
            this.disableCoupon = In.readBoolean();
            this.countLimited = In.readBoolean();
            this.termLimited = In.readBoolean();
            this.again = In.readBoolean();
            this.recommended = In.readBoolean();
            this.sale = In.readBoolean();
            this.bargain = In.readBoolean();
            this.maleOnly = In.readBoolean();
            this.femaleOnly = In.readBoolean();
            this.isGiftItem = In.readBoolean();
            this.isGiftOnly = In.readBoolean();
            this.isRequirementMet = In.readBoolean();
            this.isForOppositeGender = In.readBoolean();
            this.soldOut = In.readBoolean();
            this.setItemSize = In.readInt();

            if (this.setItemSize > 0)
            {
                this.setItemData = new List<ShopSetItemData>();
                this.setItemSize.Times(() =>
                {

                   var shopSetItem = new ShopSetItemData();
                    shopSetItem.readData(In, hasItemType);
                    this.setItemData.Add(shopSetItem);

                   
                });
            }

        }


        public List<ShopSetItemData> setItemData { get; set; }

        public bool isAmeShop { get; set; }

        public string seriesCode { get; set; }

        public string seriesTypeCode { get; set; }
    }

}