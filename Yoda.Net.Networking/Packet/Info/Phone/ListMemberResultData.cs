using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Yoda.Net.Networking.Data.Phone;



namespace Yoda.Net.Networking.Packet.Info.Phone
{
    public class AddMessageResultData : ICommandData
    {
        public AddMessageResultData()
        {
        }



        public void writeData(PiggStream stream)
        {
            stream.writeDouble(this.message.groupId);
            stream.writeDouble(this.message.boardId);
            stream.writeInt(this.message.num);
            stream.writeUTF(this.message.message);
            stream.writeUTF(this.message.userCode);
            stream.writeDouble(this.message.postTime);

            return;
        }
        public void readData(PiggStream stream)
        {
            this.message = new PhoneMessageData();
            this.message.groupId = stream.readDouble();
            this.message.boardId = stream.readDouble();
            this.message.num = stream.readInt();
            this.message.message = stream.readUTF();
            this.message.userCode = stream.readUTF();
            this.message.postTime = stream.readDouble();
        }
        public int packetId
        {
            get
            {
                return PacketId.ADD_GROUPMESSAGE_MESSAGE_RESULT;
            }
        }


        public PhoneMessageData message { get; set; }
    }
}
