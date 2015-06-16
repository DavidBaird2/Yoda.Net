namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class TiredData : IPacket, IEncrypted
    {
        private int _level;

        public TiredData(int level)
        {
            this._level = level;
        }

        public int packetId
        {
            get
            {
                return 0x204;
            }
        }

        public void readData(AmebaStream In)
        {
            this._level = In.readByte();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeByte((byte) this._level);
        }
    }
}

