using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Yoda.Net.Networking.Data.Phone;



namespace Yoda.Net.Networking.Packet.Info.Phone
{
    public class ListMemberResultData  : ICommandData
	{
        public ListMemberResultData()
        {
        }


      
        public void writeData(PiggStream stream) 
        {

            throw new NotImplementedException();
       
        }
        public void readData(PiggStream stream)
        {
             PhoneMemberData phoneMemberData = null;

             this.hasNext = stream.readBoolean();
            this.nextStart = stream.readInt();

            var count = stream.readInt();

			this.memberList = new List<PhoneMemberData>(count);

            count.Times(() =>
            {
                phoneMemberData = new PhoneMemberData();
                phoneMemberData.readData(stream, false);

                this.memberList.Add(phoneMemberData);
               
            });
        }
        public int packetId
        {
            get
            {
                return PacketId.ADD_GROUPMESSAGE_MESSAGE;
            }
        }

        public double groupId { get; set; }

        public string message { get; set; }

        public List<PhoneMemberData> memberList { get; set; }

        public int nextStart { get; set; }

        public bool hasNext { get; set; }
    }
}
