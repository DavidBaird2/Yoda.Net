using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Good
{
    public class GoodData
    {
        public static string FROM_ID_PC = "pc";                 
		public static string FROM_ID_SP = "sp";                 
        public static string FROM_ID_MB = "mb";                 
        public string userCode;                                     //slotID:0
		public string amebaId;                                      //slotID:0
		public string nickname;                                     //slotID:0
		public DateTime date;                                           //slotID:0
		public string fromID;                                       //slotID:0
		public bool sent;                                        //slotID:0
		public string type;                                         //slotID:0
		public bool friendable;                                  //slotID:0
		public string oneMessage;                                   //slotID:0

    }
}
