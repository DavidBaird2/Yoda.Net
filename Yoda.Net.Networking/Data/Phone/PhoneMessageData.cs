using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoda.Net.Networking.Data.Phone
{
	public class PhoneMessageData
	{
		public double groupId;                                
		public double boardId;                                    
		public int num;                                           
		public short type;                                       
		public string message;                                    
		public string userName;                                   
		public string userCode;                                   
		public bool smsAccepted;                               
		public double postTime;                                   
		public short from;                                       

		public void readData(PiggStream In)
		{	
			this.boardId = In.readDouble();
			this.num = In.readInt();
			this.type = In.readShort();
			this.message = In.readUTF();
			this.userName = In.readUTF();
			this.userCode = In.readUTF();
			this.smsAccepted = In.readBoolean();
			this.postTime = In.readDouble();
			this.from = In.readShort();
		}
        public void writeData(PiggStream Out)
        {
            Out.writeDouble(boardId);
            Out.writeInt(num);
            Out.writeShort(type);
            Out.writeUTF(message);
            Out.writeUTF(userName);
            Out.writeUTF(userCode);
            Out.writeBoolean(smsAccepted);
            Out.writeDouble(postTime);
            Out.writeShort(from);
        }
	}
}
