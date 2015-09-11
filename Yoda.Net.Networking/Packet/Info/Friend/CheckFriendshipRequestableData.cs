namespace Yoda.Net.Networking.Packet.Info.Friend
{
    
    
    using System;
    using System.Collections;


    public class CheckFriendshipRequestableData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.CHECK_FRIENDSHIP_REQUESTABLE;
            }
        }

        public void readData(PiggStream In)
        {

            userCode = In.readUTF();
        }


        public void writeData(PiggStream Out)
        {
            Out.writeUTF(this.userCode);
        }





        public string userCode { get; set; }
    }
}

