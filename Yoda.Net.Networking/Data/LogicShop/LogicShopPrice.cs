
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.LogicShop
{
   public class LogicShopPrice
    {
        public string shopCode;                                     
        public int price;                                           
		public int shopType;                                        

		public void readData(PiggStream In)
		{	//MethodID:24386, LocalCount= 2 , MaxScope= 1, MaxStack= 2, CodeLength= 23
            this.shopCode = In.readUTF();
            this.price = In.readInt();
		}
    }
}
