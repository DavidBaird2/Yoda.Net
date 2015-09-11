using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Yoda.Net.Networking.Data.Phone;



namespace Yoda.Net.Networking.Packet.Info.Phone
{
    public class UpdateGroupData : ICommandData
	{
        public UpdateGroupData()
        {
        }


      
        public void writeData(PiggStream stream) 
        {

            stream.writeDouble(this.groupId);
            stream.writeUTF(this.updateTitle);
            return;
        }
        public void readData(PiggStream stream)
        {
            groupId = stream.readDouble();
            updateTitle = stream.readUTF();
        }
        public int packetId
        {
            get
            {
                return PacketId.UPDATE_GROUPMESSAGE_GROUP;
            }
        }

        public double groupId { get; set; }

        public string updateTitle { get; set; }
    }
}
