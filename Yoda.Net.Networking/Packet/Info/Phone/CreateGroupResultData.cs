using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Yoda.Net.Networking.Data.Phone;



namespace Yoda.Net.Networking.Packet.Info.Phone
{
    public class CreateGroupResultData : ICommandData
    {
        public CreateGroupResultData()
        {
        }

        public void writeData(PiggStream stream)
        {
            throw new NotImplementedException();
          
        }
        public void readData(PiggStream stream)
        {

            this.isSuccess = stream.readBoolean();

            if (this.isSuccess)
            {
                var groupId = stream.readDouble();
                var title = stream.readUTF();
                var nunMember = stream.readInt();
                var closedGroup = stream.readBoolean();
                this.data = new PhoneGroupData(groupId, nunMember, closedGroup);
                this.data.title = title;
            }
        }
        public int packetId
        {
            get
            {
                return PacketId.CREATE_GROUPMESSAGE_GROUP_RESULT;
            }
        }

        public bool isSuccess { get; set; }

        public PhoneGroupData data { get; set; }
    }
}
