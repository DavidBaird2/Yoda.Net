namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;

    public class AddBlockUserResultData : ICommandData
    {
 

   
        public int packetId
        {
            get
            {
                return PacketId.ADD_BLOCK_USER_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            this.success = In.readBoolean();
            this.userCode = In.readUTF();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeBoolean(success);
            Out.writeUTFBytes(userCode);
        }

        public bool success { get; set; }

        public string userCode { get; set; }
    }
}

