using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


using Yoda.Net.Networking.Packet.Data.phone;

namespace Yoda.Net.Networking.Packet.Info.phone
{
    public class CreateGroupData : IPacket
	{
        private bool _oneToOne;
        private ArrayList _memberList;
        private string _title;

        public CreateGroupData(bool oneToOne, string title, ArrayList memberList)
        {
            _oneToOne = oneToOne;
            _title = title;
            _memberList = memberList;
            return;
        }
        public void writeData(AmebaStream param1) 
        {
            param1.writeBoolean(_oneToOne);
            param1.writeUTF(_title);
            var count = _memberList.Count;
            param1.writeInt(count);
            foreach (PhoneMemberData _loc_4 in _memberList)
            {
                param1.writeUTF(_loc_4.userCode);
            }

            return;
        }
        public void readData(AmebaStream param1)
        {
            return;
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
