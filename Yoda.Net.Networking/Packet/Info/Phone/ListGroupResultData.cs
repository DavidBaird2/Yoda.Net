using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Yoda.Net.Networking.Data.Phone;



namespace Yoda.Net.Networking.Packet.Info.Phone
{
    public class ListGroupResultData : ICommandData
	{
        public ListGroupResultData()
        {
        }


      
        public void writeData(PiggStream stream) 
        {
            throw new NotImplementedException();
            /*ream.writeDouble(this.groupId);
            stream.writeInt(this.start);
            return;*/
        }
        public void readData(PiggStream stream)
        {
            PhoneGroupData  phoneGroupData = null;

	
			this.confirmGroupMessageAlert = stream.readBoolean();
			this.isOverGroupLimit = stream.readBoolean();
			this.hasNext = stream.readBoolean();
			this.nextStart = stream.readInt();

			int count = stream.readInt();

			this.groupList = new List<PhoneGroupData>(count);

            count.Times(() =>
            {
                var groupId = stream.readDouble();
                var title = stream.readUTF();
                var numMember = stream.readInt();
                var isClosedGroup = stream.readBoolean();
                phoneGroupData = new PhoneGroupData(groupId, numMember, isClosedGroup);
                phoneGroupData.title = title;
                phoneGroupData.readData(stream);

                this.groupList.Add(phoneGroupData);
               
            });
        }
        public int packetId
        {
            get
            {
                return PacketId.LIST_GROUPMESSAGE_GROUP_RESULT;
            }
        }

        public double groupId { get; set; }

        public int start { get; set; }

        public bool confirmGroupMessageAlert { get; set; }

        public bool isOverGroupLimit { get; set; }

        public bool hasNext { get; set; }

        public int nextStart { get; set; }

        public List<PhoneGroupData> groupList { get; set; }
    }
}
