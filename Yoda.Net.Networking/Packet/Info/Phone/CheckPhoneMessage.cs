using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Yoda.Net.Networking.Data.Phone;



namespace Yoda.Net.Networking.Packet.Info.Phone
{
    public class CheckPhoneMessage : ICommandData
	{
        public CheckPhoneMessage()
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
                return PacketId.CHECK_GROUPMESSAGE_MESSAGE;
            }
        }

        public double groupId { get; set; }
    }
}
