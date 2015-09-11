namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;
    

    public class SystemActionData : ICommandData, IEncrypted
    {

        public string code;

        public SystemActionData()
        {
        }

        public SystemActionData(string code)
        {
            this.code = code;
        }

        public int packetId
        {
            get
            {
                return 0x414;
            }
        }

        public void readData(PiggStream In)
        {
            this.code = In.readUTF();
            
        }

        public void writeData(PiggStream Out)
        {
                 Out.writeUTF(this.code);
        }
    }
}

