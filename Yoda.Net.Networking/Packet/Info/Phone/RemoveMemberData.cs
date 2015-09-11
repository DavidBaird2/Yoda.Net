using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Yoda.Net.Networking.Data.Phone;



namespace Yoda.Net.Networking.Packet.Info.Phone
{
    public class RemoveMemberData : ICommandData
	{
        public RemoveMemberData()
        {
        }


      
        public void writeData(PiggStream stream) 
        {

            stream.writeDouble(this.groupId);
            return;
        }
        public void readData(PiggStream stream)
        {
            groupId = stream.readDouble();
        }
        public int packetId
        {
            get
            {
                return PacketId.REMOVE_GROUPMESSAGE_GROUP_MEMBER;
            }
        }

        public double groupId { get; set; }
    }
}
