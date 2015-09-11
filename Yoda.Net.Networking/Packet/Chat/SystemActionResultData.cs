namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;
    

    public class SystemActionResultData : ICommandData
    {
        public string code;
        public string userCode;
        public SystemActionResultData()
        {
            
        }

        public SystemActionResultData(string code)
        {
            this.code = code;
        }

        public int packetId
        {
            get
            {
                return PacketId.SYSTEM_ACTION_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            this.userCode = In.readUTF();
            this.code = In.readUTF();
            
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(this.userCode);
           Out.writeUTF(this.code);
        }
    }
}

