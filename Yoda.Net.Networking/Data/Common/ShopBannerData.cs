using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoda.Net.Networking.Data.Common
{
   public class ShopBannerData
    {
        public void readData(PiggStream In)
		{	
			this.orderNum = In.readInt();
			this.category = In.readUTF();
			this.code = In.readUTF();
			this.subImageCode = In.readUTF();
			this.name = In.readUTF();
			this.viewType = In.readUTF();
			this.saleId = In.readInt();
			this.shopKind = In.readInt();
			this.seriesTypeCode = In.readUTF();
			this.campaignCode = In.readUTF();
			this.campaignSubImageCode = In.readUTF();
			this.bannerInfo = new ShopBannerCodeInfo();
			this.bannerInfo.seriesCode = this.code;
			this.bannerInfo.seriesTypeCode = this.seriesTypeCode;
		}

        public int orderNum { get; set; }

        public string category { get; set; }

        public string code { get; set; }

        public string subImageCode { get; set; }

        public string name { get; set; }

        public string viewType { get; set; }

        public int saleId { get; set; }

        public int shopKind { get; set; }

        public string seriesTypeCode { get; set; }

        public string campaignCode { get; set; }

        public string campaignSubImageCode { get; set; }

        public ShopBannerCodeInfo bannerInfo { get; set; }
    }
}
