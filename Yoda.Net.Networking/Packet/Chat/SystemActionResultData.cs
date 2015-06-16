namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;
    

    public class SystemActionResultData : IPacket
    {
        public string code;
        public string userCode;
        public SystemActionResultData()
        {
        }

        public SystemActionResultData(string param1)
        {
            this.code = param1;
        }

        public int packetId
        {
            get
            {
                return PacketId.SYSTEM_ACTION_RESULT;
            }
        }

        public void readData(AmebaStream In)
        {
            this.userCode = In.readUTF();
            this.code = In.readUTF();
            
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(this.userCode);
           Out.writeUTF(this.code);
        }
    }
}

