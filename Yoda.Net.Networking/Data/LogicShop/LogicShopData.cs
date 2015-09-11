using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.LogicShop
{
    public class LogicShopData
    {
        public string shopCode;                                     
		public int shopType;                                        

		public void readData(PiggStream In)
		{	
			this.shopCode = In.readUTF();
			this.shopType = In.readByte();
		}
    }
}
