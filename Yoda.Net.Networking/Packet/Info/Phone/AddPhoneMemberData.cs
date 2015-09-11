using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Yoda.Net.Networking.Data.Phone;



namespace Yoda.Net.Networking.Packet.Info.Phone
{
    public class AddPhoneMemberData : ICommandData
	{
        public List<PhoneMemberData> memberList;


        public double groupId { get; set; }
        public AddPhoneMemberData()
        {
        }


      
        public void writeData(PiggStream stream) 
        {
            stream.writeDouble(this.groupId);
            int count = this.memberList.Count;

            stream.writeInt(count);
            foreach (PhoneMemberData data in memberList)
            {

                stream.writeUTF(data.userCode);

            }
         
            return;
        }
        public void readData(PiggStream stream)
        {
            memberList=new List<PhoneMemberData>();
            groupId = stream.readDouble();
            int count = stream.readInt();
            for(int i=0;i<count;i++)
            {
                memberList.Add(new PhoneMemberData() { userCode = stream.readUTF() });
            }
        }
        public int packetId
        {
            get
            {
                return PacketId.ADD_GROUPMESSAGE_GROUP_MEMBER;
            }
        }
    }
}
