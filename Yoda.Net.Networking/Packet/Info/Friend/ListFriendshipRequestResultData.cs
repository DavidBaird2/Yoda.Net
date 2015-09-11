namespace Yoda.Net.Networking.Packet.Info.Friend
{
    
    
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Yoda.Net.Networking.Data.Messenger;


    public class ListFriendshipRequestResultData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.LIST_FRIENDSHIP_REQUEST_RESULT;
            }
        }

        public void readData(PiggStream In)
        {

      
			var count = In.readInt();

			this.waitings = new List<FriendWaitingData>();

			

			count.Times(()=>{
				var data = new FriendWaitingData();
				data.hexCode = In.readUTF();
				data.amebaId = In.readUTF();
				data.nickname = In.readUTF();
				data.message = In.readUTF();
				data.status = In.readByte();
				data.requestAt = In.readUTF();
				this.waitings.Add(data);
			});
        }


        public void writeData(PiggStream Out)
        {

        }





        public List<FriendWaitingData> waitings { get; set; }
    }
}

