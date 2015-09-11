using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Common
{
    public class  PiggShopData :ShopData
    {
        	public ShopNewsClipData newsClipData = new ShopNewsClipData();                       
		public ShopSaleInfoData saleInfoData= new ShopSaleInfoData();                       
		public List<ShopBannerData> banners = new List<ShopBannerData>();                     
		public VipShopStatusInfo vipShopStatus = new VipShopStatusInfo();                     
		public string onOpenShopCode;                               
		public string onOpenGachaCode;                              
		public string onOpenShopSeries;

    }
}
