using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Yoda.Net.Networking.Data.Phone;



namespace Yoda.Net.Networking.Packet.Info.Phone
{
    public class ListGroupMemberData : ICommandData
	{
        public ListGroupMemberData()
        {
        }


      
        public void writeData(PiggStream stream) 
        {

            stream.writeDouble(this.groupId);
            stream.writeInt(this.start);
            return;
        }
        public void readData(PiggStream stream)
        {
            groupId = stream.readDouble();
            start = stream.readInt();
        }
        public int packetId
        {
            get
            {
                return PacketId.LIST_GROUPMESSAGE_GROUP_MEMBER;
            }
        }

        public double groupId { get; set; }

        public int start { get; set; }
    }
}
