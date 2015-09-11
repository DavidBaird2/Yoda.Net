namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;

    public class AddBlockUserData : ICommandData, IEncrypted, IncludeClientTime
    {
 

   
        public int packetId
        {
            get
            {
                return PacketId.ADD_BLOCK_USER;
            }
        }

        public void readData(PiggStream In)
        {
            this.userCode = In.readUTF();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTFBytes(userCode);
        }


        public string userCode { get; set; }
    }
}

