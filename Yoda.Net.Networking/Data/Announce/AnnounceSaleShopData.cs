using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Announce
{
    public class AnnounceSaleShopData
    {
        public void readData(PiggStream In)
		{	

			this.nickName = In.readUTF();
			this.saleId = In.readInt();
			this.endTime = In.readTime();
			this.shopCode = In.readUTF();
			this.description = In.readUTF();
			this.template = In.readUTF();
			this.announceKey = this.template;

			int count = In.readInt();

			this.itemList = new List<AnnounceSaleShopItemData>();


            count.Times(() =>
            {
               var data = new AnnounceSaleShopItemData();
                data.readData(In);

                this.itemList.Add(data);
            });

			this.shopTypeNo = In.readByte();

			if(this.shopTypeNo == 1){//SHOP_TYPE_GUERRILLA
				this.limitBuyNum = In.readInt();
				this.discountRate = In.readInt();
				this.saleTime = new Yoda.Net.Networking.Data.Time.RemainTimeData(In.readDouble());
			//	this.template = AnnounceSaleShopData.TEMPLETE_GUERRILLA_SWF;
			}
		}

        public List<AnnounceSaleShopItemData> itemList { get; set; }

        public string nickName { get; set; }

        public int saleId { get; set; }

        public string shopCode { get; set; }

        public DateTime endTime { get; set; }

        public string description { get; set; }

        public string template { get; set; }

        public string announceKey { get; set; }

        public sbyte shopTypeNo { get; set; }

        public int limitBuyNum { get; set; }

        public int discountRate { get; set; }

        public Time.RemainTimeData saleTime { get; set; }
    }
}
