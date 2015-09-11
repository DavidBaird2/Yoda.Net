using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoda.Net.Networking.Data.Phone
{
    public class PhoneGroupData
    {
        private double groupId;
        private int numMember;
        public string title;
        public string userCode;
        public bool hasNewMessage;
        public bool existMessage;
        public int type;
        public string message;
        public DateTime postTime;
        public bool isClosedGroup;
        public PhoneGroupData(double groupId, int numMember, bool isClosedGroup)
		{	
			
			this.groupId = groupId;
			this.numMember = numMember;
			this.isClosedGroup = isClosedGroup;
		}
        public void readData(PiggStream In)
        {

            this.userCode = In.readUTF();
            this.hasNewMessage = In.readBoolean();
            this.existMessage = In.readBoolean();

            if (this.existMessage)
            {
                this.type = In.readShort();
                this.message = In.readUTF();
                this.postTime = In.readTime();
            }


        }
        public void writeData(PiggStream In)
        {
            In.writeUTF(userCode);
            In.writeBoolean(hasNewMessage);
            In.writeBoolean(existMessage);

            if (existMessage)
            {
                In.writeShort((short)type);
                In.writeUTF(message);
                In.writeDate(postTime);
            }
        }

    }
}
