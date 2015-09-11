using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Yoda.Net.Networking.Data.Collectioncampaign;
using Yoda.Net.Networking.Data.Shop;


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

        public string campaignCode;
        public bool isEnableDarts;
        public string infoUrl;

        public string code;
        public string description2;

        public string template;
        public int playCount;
        public string description;
        public static int PAY_TYPE_GOLD = 0;                      //slotID:1
        public static int PAY_TYPE_CANDY = 1;                     //slotID:2
        public static int PAY_TYPE_COUPON = 2;                    //slotID:3
        public static int PAY_TYPE_FISHING = 3;                   //slotID:4
        public static int PAY_TYPE_CASINO = 4;                    //slotID:5
        public static int ITEM_TYPE_NORMAL = 0;                   //slotID:6
        public static int ITEM_TYPE_RARE = 1;                     //slotID:7
        public static int ITEM_TYPE_SUPER_RARE = 2;               //slotID:8
        public static int GACHA_TYPE_NORMAL = 0;                  //slotID:9
        public static int GACHA_TYPE_VIP = 1;                     //slotID:10

        public ShopCoinBannerLinkInfo coinBannerLinkInfo = new ShopCoinBannerLinkInfo();
        public void readData(PiggStream bytes)
        {
            //slotID:1
            int i;                                                      //slotID:2
            CollectionCampaignItemData featuredItem;                    //slotID:3
            bool hasFeatureStep;                                     //slotID:4
            int stepLoop;                                               //slotID:5
            int stepPrice;                                              //slotID:6
            int bonusSize;                                              //slotID:7
            int bonusLoop;                                              //slotID:8
            string bonusType;                                           //slotID:9
            int quantity;                                               //slotID:10
            string itemCode;                                            //slotID:11
            string itemName;                                            //slotID:12
            string itemType;                                            //slotID:13

            featuredItem = null;
            hasFeatureStep = false;
            stepLoop = 0;
            stepPrice = 0;
            bonusSize = 0;
            bonusLoop = 0;
            bonusType = null;
            quantity = 0;
            itemCode = null;
            itemName = null;
            itemType = null;

            this.stepupBonusData = new GachaStepupBonusListData();
            this.code = bytes.readUTF();
            this.name = bytes.readUTF();
            this.description = bytes.readUTF();
            this.description2 = bytes.readUTF();
            this.template = bytes.readUTF();
            this.gachaType = bytes.readByte();
            this.payType = bytes.readByte();
            this.price = bytes.readInt();
            this.stepupBonusData.originalPrice = this.price;
            this.startTime = bytes.readTime();
            this.endTime = bytes.readTime();
            this.freePlayStartTime = bytes.readTime();
            this.freePlayEndTime = bytes.readTime();
            this.point = bytes.readInt();
            this.isDisEnableCoupon = bytes.readBoolean();
            this.couponQuantiry = bytes.readInt();
            this.isEnableDarts = bytes.readBoolean();
            this.genderCode = bytes.readInt();
            this.remainingFreePlayCount = bytes.readInt();
            this.isIncludeSecretItem = bytes.readBoolean();
            this.noOverlapRemainCount = bytes.readInt();
            this.noOverlapRemainTime = bytes.readDouble();

            if ((this.noOverlapRemainCount > 0) && (this.noOverlapRemainTime == 0))
            {
                this.noOverlapEternalMode = true;
            }
            else
            {
                this.noOverlapEternalMode = false;
            }

            int featuredItemsCount = bytes.readInt();

            this.featuredItems = new List<CollectionCampaignItemData>(bytes.readInt());
            i = 0;

            featuredItemsCount.Times(() =>
            {
                featuredItem = new CollectionCampaignItemData();
                featuredItem.readData(bytes);

                featuredItem.isSetItem = bytes.readBoolean();
                this.featuredItems.Add(featuredItem);
                i++;
            });

            this.ultraRareGetRate = bytes.readDouble();
            this.rareGetRate = bytes.readDouble();
            this.normalGetRate = bytes.readDouble();
            this.isStepup = bytes.readBoolean();

            if (this.isStepup)
            {
                hasFeatureStep = false;

                if (this.additionalFeatureList == null) this.additionalFeatureList = new List<GachaStepupBonusAdditionalFeatureData>();

                this.stepCount = bytes.readInt();
                this.stepTotal = bytes.readInt();
                this.stepupBonusData.initialize(this.stepTotal);

                if (this.stepCount > 0) this.stepCount--;

                stepLoop = 0;

                while (stepLoop < this.stepTotal)
                {
                    stepPrice = bytes.readInt();
                    hasFeatureStep = bytes.readBoolean();
                    bonusSize = bytes.readInt();
                    this.stepupBonusData.list[stepLoop].price = stepPrice;
                    bonusLoop = 0;

                    while (bonusLoop < bonusSize)
                    {
                        bonusType = bytes.readUTF();
                        quantity = bytes.readInt();
                        itemCode = "";
                        itemName = "";
                        itemType = "";
                        itemCode = bytes.readUTF();
                        itemName = bytes.readUTF();
                        itemType = bytes.readUTF();
                        this.stepupBonusData.list[stepLoop].addData(bonusType, quantity, itemCode, itemName, itemType);

                        if ((bonusLoop == 0) && (this.stepupBonusData.list[stepLoop].itemGroupList.Count > 0)) this.additionalFeatureList.Add(new GachaStepupBonusAdditionalFeatureData(stepLoop + 1, this.stepupBonusData.list[stepLoop].itemGroupList[0], hasFeatureStep));

                        bonusLoop++;
                    }

                    stepLoop++;
                }

        
            }

            this.coinBannerLinkInfo.readData(bytes);
        }


        internal GachaStepupBonusListData stepupBonusData { get; set; }

        public sbyte gachaType { get; set; }

        public DateTime startTime { get; set; }

        public DateTime endTime { get; set; }

        public DateTime freePlayStartTime { get; set; }

        public DateTime freePlayEndTime { get; set; }

        public int point { get; set; }

        public bool isIncludeSecretItem { get; set; }

        public int noOverlapRemainCount { get; set; }

        public double noOverlapRemainTime { get; set; }

        public bool noOverlapEternalMode { get; set; }

        public List<CollectionCampaignItemData> featuredItems { get; set; }

        public double ultraRareGetRate { get; set; }

        public double rareGetRate { get; set; }

        public double normalGetRate { get; set; }

        public bool isStepup { get; set; }

        public List<GachaStepupBonusAdditionalFeatureData> additionalFeatureList { get; set; }

        public int stepCount { get; set; }

        public int stepTotal { get; set; }
    }
}
