using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Networking.Data.Common;

namespace Yoda.Net.Networking.Data.Gacha
{
    public class ShopGachaData
    {
        public void readData(PiggStream In)
        {
            this.code = In.readUTF();
            this.name = In.readUTF();
            this.payType = In.readByte();
            this.price = In.readInt();
            this.isDisEnableCoupon = In.readBoolean();


            this.time = In.readTime();
            this.remainingFreePlayCount = In.readInt();


            this.freePlayStartDate = In.readTime();


            this.freePlayEndDate = In.readTime();

            this.isNoOverlap = In.readBoolean();
            this.noOverlapRemainTime = In.readTime();
            this.isStepup = In.readBoolean();

            if (this.isNoOverlap && (this.noOverlapRemainTime == DateTime.Parse("1970/1/1 09:00")))
            {
                this.noOverlapEternalMode = true;
            }
            else
            {
                this.noOverlapEternalMode = false;
            }

            this.collectionItemList = new List<GachaItemData>(1);

            GachaItemData gachaItemData = new GachaItemData();

            gachaItemData.readData(In);

            this.collectionItemList.Add(gachaItemData);
        }


        public string code { get; set; }
        public string name { get; set; }
        public sbyte payType { get; set; }
        public int price { get; set; }
        public bool isDisEnableCoupon { get; set; }
        public int remainingFreePlayCount { get; set; }
        public DateTime time { get; set; }
        public DateTime freePlayStartDate { get; set; }
        public DateTime freePlayEndDate { get; set; }
        public bool isNoOverlap { get; set; }
        public DateTime noOverlapRemainTime { get; set; }
        public bool isStepup { get; set; }
        public bool noOverlapEternalMode { get; set; }
        public List<GachaItemData> collectionItemList { get; set; }



        public string getInformationText(bool syouryaku = true, int syouryakuKeta = 0)
        {
            string result = "";

            if (syouryaku)
            {
                if ((this.name.Count() > syouryakuKeta) && (syouryakuKeta > 0))
                {
                    result += (this.name.Substring(0, syouryakuKeta) + "...\n");
                }
                else
                {
                    result += (this.name + "\n");
                }
            }

            result += (this.price) + ShopData.getPriceUnit(this.payType);

            if ((this.remainingFreePlayCount > 0) && (this.freePlayEndDate != null)) result += ((("\n【初回無料期間】" + this.freePlayEndDate.Month + 1 + "/") + this.freePlayEndDate.Day) + "まで");

            return result;
        }
    }
}
