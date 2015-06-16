namespace Yoda.Net.Networking.Data.Common
{
    using System;
    using System.Collections;
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
            //log(this);
            return;
        }

        public void readData(AmebaStream param1)
        {
            this.shelf = param1.readUTF();
            this.type = param1.readUTF();
            this.category = param1.readUTF();
            this.itemId = param1.readUTF();
            this.name = param1.readUTF();
            this.description = param1.readUTF();
            this.price = param1.readInt();
            this.originalPrice = param1.readInt();
            this.remainTime = param1.readDouble();
            this.stock = param1.readInt();
            this.orderNum = param1.readInt();
            this.quantity = param1.readInt();
            this.newItem = param1.readBoolean();
            this.disableCoupon = param1.readBoolean();
            this.countLimited = param1.readBoolean();
            this.termLimited = param1.readBoolean();
            this.again = param1.readBoolean();
            this.recommended = param1.readBoolean();
            this.sale = param1.readBoolean();
            this.bargain = param1.readBoolean();
            this.maleOnly = param1.readBoolean();
            this.femaleOnly = param1.readBoolean();
            this.isGiftItem = param1.readBoolean();
            this.isGiftOnly = param1.readBoolean();
            this.isRequirementMet = param1.readBoolean();
            this.isForOppositeGender = param1.readBoolean();
            this.soldOut = param1.readBoolean();
            this.setItemSize = param1.readInt();
            if (this.setItemSize > 0)
            {
                // this.setItemData = new Vector.<ShopSetItemData>;
                int _loc_2 = 0;
                while (_loc_2 < this.setItemSize)
                {
                    param1.readUTF();
                    param1.readUTF();
                    param1.readUTF();

                    param1.readInt();
                    _loc_2++;
                }

            }
            return;

        }

    }

}