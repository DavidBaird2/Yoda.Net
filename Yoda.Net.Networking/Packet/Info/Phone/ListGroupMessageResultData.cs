using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Yoda.Net.Networking.Data.Phone;



namespace Yoda.Net.Networking.Packet.Info.Phone
{
    public class ListGroupMessageResultData : ICommandData
    {
        public ListGroupMessageResultData()
        {
        }



        public void writeData(PiggStream stream)
        {
            throw new NotImplementedException();
           
        }
        public void readData(PiggStream stream)
        {
          
            double groupId = stream.readDouble();
            int numMember = stream.readInt();

            this.groupData = new PhoneGroupData(groupId, numMember, false);
            this.option = stream.readInt();
            this.hasPrev = stream.readBoolean();

            int messageCount = stream.readInt();

            this.messageList = new List<PhoneMessageData>(messageCount);

            messageCount.Times(() =>
           {
               PhoneMessageData messageData = new PhoneMessageData();
               messageData.groupId = groupId;
               messageData.readData(stream);

               this.messageList.Add(messageData);
             
           });
        }
        public int packetId
        {
            get
            {
                return PacketId.LIST_GROUPMESSAGE_MESSAGE_RESULT;
            }
        }



        public PhoneGroupData groupData { get; set; }

        public int option { get; set; }

        public bool hasPrev { get; set; }

        public List<PhoneMessageData> messageList { get; set; }
    }
}
