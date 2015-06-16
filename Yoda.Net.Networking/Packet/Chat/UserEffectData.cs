namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class UserEffectData : IPacket
    {
        private string _code;
        public string code;

        public UserEffectData()
        {
        }

        public UserEffectData(string param1)
        {
            this._code = param1;
        }

        public int packetId
        {
            get
            {
                return 1050;
            }
        }

        public void readData(AmebaStream In)
        {
            this.code = In.readUTF();
            
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(this._code);
        }
    }
}

