using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Yoda.Net.Networking.Data.Phone;



namespace Yoda.Net.Networking.Packet.Info.Phone
{
    public class ListGroupMessageData : ICommandData
	{
        public ListGroupMessageData()
        {
        }


      
        public void writeData(PiggStream stream) 
        {

            stream.writeDouble(this.groupId);
            stream.writeInt(this.option);

            if ((this.option == 1) || (this.option == 2))
            {
                stream.writeDouble(this.boardId);
                stream.writeInt(this.number);
            }
            return;
        }
        public void readData(PiggStream stream)
        {
            groupId = stream.readDouble();
            option = stream.readInt();
            if ((this.option == 1) || (this.option == 2))
            {
                boardId = stream.readDouble();
                number = stream.readInt();
            }
        }
        public int packetId
        {
            get
            {
                return PacketId.LIST_GROUPMESSAGE_MESSAGE;
            }
        }

        public int option { get; set; }

        public double groupId { get; set; }

        public double boardId { get; set; }

        public int number { get; set; }
    }
}
