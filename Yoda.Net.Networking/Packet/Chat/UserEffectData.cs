namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class UserEffectData : ICommandData
    {

        public string code;

        public UserEffectData()
        {
        }

        public UserEffectData(string code)
        {
            this.code = code;
        }

        public int packetId
        {
            get
            {
                return 1050;
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

