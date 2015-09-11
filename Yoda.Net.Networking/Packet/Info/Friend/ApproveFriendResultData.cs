namespace Yoda.Net.Networking.Packet.Info.Friend
{
    
    
    using System;
    using System.Collections;
    using System.Collections.Generic;


    public class ApproveFriendResultData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.APPROVE_FRIENDSHIP_RESULT;
            }
        }

        public void readData(PiggStream In)
        {

            this.hexCode = In.readUTF();
            this.amebaId = In.readUTF();
            this.nickName = In.readUTF();
            this.isSuccess = In.readBoolean();
            this.isApproval = In.readBoolean();
            this.friendMaxNum = In.readInt();
        }


        public void writeData(PiggStream Out)
        {
       
            throw new NotImplementedException();
        }



        public string hexCode { get; set; }

        public string amebaId { get; set; }

        public string nickName { get; set; }

        public bool isSuccess { get; set; }

        public bool isApproval { get; set; }

        public int friendMaxNum { get; set; }
    }
}

