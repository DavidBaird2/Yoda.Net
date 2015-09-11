namespace Yoda.Net.Networking.Packet.Info.Friend
{
    
    
    using System;
    using System.Collections;


    public class RequestFriendshipData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.REQUEST_FRIENDSHIP;
            }
        }

        public void readData(PiggStream In)
        {

            userCode = In.readUTF();
            situation = In.readInt();
            message = In.readUTF();
            isMiniTalk = In.readBoolean();
        }


        public void writeData(PiggStream Out)
        {
            Out.writeUTF(this.userCode);
            Out.writeInt(this.situation);
            Out.writeUTF(this.message);
            Out.writeBoolean(this.isMiniTalk);
        }




        public string userCode { get; set; }

        public int situation { get; set; }

        public string message { get; set; }

        public bool isMiniTalk { get; set; }
    }
}

