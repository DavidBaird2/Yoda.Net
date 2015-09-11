namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;

    public class BanData : ICommandData
    {
        private string _code;
        private bool _isBanned;

        public BanData(string code, bool isBanned)
        {
            this._code = code;
            this._isBanned = isBanned;
        }
        public BanData()
        {

        }
        public int packetId
        {
            get
            {
                return 0x42f;
            }
        }

        public void readData(PiggStream In)
        {
            throw new NotImplementedException();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(this._code);
            Out.writeBoolean(this._isBanned);
        }
    }
}

