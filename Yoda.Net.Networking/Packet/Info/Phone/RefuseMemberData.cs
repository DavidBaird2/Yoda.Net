using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Yoda.Net.Networking.Data.Phone;



namespace Yoda.Net.Networking.Packet.Info.Phone
{
    public class RefuseMemberData : ICommandData
	{
        public RefuseMemberData()
        {
        }


      
        public void writeData(PiggStream stream) 
        {

            stream.writeUTF(this.userCode);
            stream.writeBoolean(this.banned);
            return;
        }
        public void readData(PiggStream stream)
        {
            userCode = stream.readUTF();
            banned = stream.readBoolean();
        }
        public int packetId
        {
            get
            {
                return PacketId.BAN_GROUPMESSAGE;
            }
        }

        public string userCode { get; set; }

        public bool banned { get; set; }
    }
}
