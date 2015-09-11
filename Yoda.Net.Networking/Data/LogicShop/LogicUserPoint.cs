using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoda.Net.Networking.Data.LogicShop
{
   public class LogicUserPoint
    {
        	public int point;                                        
		public int shopType;                                       

		public void readData(PiggStream In)
		{	
			this.shopType = In.readByte();
			this.point = In.readInt();
		}
    }
}
