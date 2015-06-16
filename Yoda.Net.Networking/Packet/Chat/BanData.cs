namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;

    public class BanData : IPacket
    {
        private string _code;
        private bool _isBanned;

        public BanData(string param1, bool param2)
        {
            this._code = param1;
            this._isBanned = param2;
        }

        public int packetId
        {
            get
            {
                return 0x42f;
            }
        }

        public void readData(AmebaStream In)
        {
            
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(this._code);
            Out.writeBoolean(this._isBanned);
        }
    }
}

