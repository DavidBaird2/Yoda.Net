using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoda.Net.Networking.Data.Gacha
{
    public class GachaStepupBonusOneStepListData
    {
        public GachaStepupBonusOneStepListData()
        {
            
			this.optionGroupList = new List<GachaStepupOptionData>();
			this.itemGroupList = new List<GachaStepupItemData>();
        }
        public void addData(string bonusType, int quantity, string itemCode, string itemName, string itemType)
        {	
            GachaStepupItemData itemData = null;
            GachaStepupOptionData optionData = null;

            if (bonusType == "addItem")
            {
                itemData = new GachaStepupItemData(quantity, itemCode, itemName, itemType);
                this.itemGroupList.Add(itemData);
            }
            else
            {
                optionData = new GachaStepupOptionData(bonusType, quantity);
                this.optionGroupList.Add(optionData);
            }
        }



        public List<GachaStepupOptionData> optionGroupList { get; set; }

        public List<GachaStepupItemData> itemGroupList { get; set; }

        public int price { get; set; }
    }
}
