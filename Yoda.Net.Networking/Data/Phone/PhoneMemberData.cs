using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoda.Net.Networking.Data.Phone
{
	public class PhoneMemberData
	{
		public string userCode;                                    
		public string amebaId;                                     
		public string nickName;                                    
		public bool smsAccepted;                                
		public bool isOnline;                                   
		public string templeteMessage;                             
		public bool friendRequestable;                          

		public void readData(PiggStream In,bool friendRequestable)
		{	
            this.userCode = In.readUTF();
            this.amebaId = In.readUTF();
            this.nickName = In.readUTF();
            this.smsAccepted = In.readBoolean();

            if (friendRequestable) this.friendRequestable = In.readBoolean();

            this.isOnline = In.readBoolean();
		}
	}
}
