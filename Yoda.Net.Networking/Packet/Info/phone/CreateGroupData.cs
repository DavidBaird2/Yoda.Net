using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Yoda.Net.Networking.Data.Phone;



namespace Yoda.Net.Networking.Packet.Info.phone
{
    public class CreateGroupData : ICommandData
	{
        public CreateGroupData()
        {
        }
        private bool oneToOne;
        private ArrayList memberList;
        private string title;

        public CreateGroupData(bool oneToOne, string title, ArrayList memberList)
        {
            this.oneToOne = oneToOne;
            this.title = title;
            this.memberList = memberList;
            return;
        }
        public void writeData(PiggStream stream) 
        {
            stream.writeBoolean(oneToOne);
            stream.writeUTF(title);
            var count = memberList.Count;
            stream.writeInt(count);
            foreach (PhoneMemberData member in memberList)
            {
                stream.writeUTF(member.userCode);
            }

            return;
        }
        public void readData(PiggStream stream)
        {
            throw new NotImplementedException();
        }
        public int packetId
        {
            get
            {
                return PacketId.CREATE_GROUPMESSAGE_GROUP;
            }
        }
	}
}
