using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoda.Net.Networking.Data.Common
{
   public  class VipShopStatusInfo
    {
       public void readData(PiggStream In)
		{	
			this.vipShopId = In.readInt();
			this.showPanel = In.readByte();
			this.isVip = In.readBoolean();
			this.startMonth = In.readInt();
			this.remainTime =  In.readDouble();
			this.remainToAchieve = In.readInt();
		}

       public int vipShopId { get; set; }

       public sbyte showPanel { get; set; }

       public bool isVip { get; set; }

       public int startMonth { get; set; }

       public int remainToAchieve { get; set; }

       public double remainTime { get; set; }
    }
}
