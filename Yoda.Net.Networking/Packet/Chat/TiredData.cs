namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class TiredData : ICommandData, IEncrypted
    {
        public TiredData()
        {
        }
        private int level;

        public TiredData(int level)
        {
            this.level = level;
        }

        public int packetId
        {
            get
            {
                return 0x204;
            }
        }

        public void readData(PiggStream In)
        {
            this.level = In.readByte();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeByte((byte) this.level);
        }
    }
}

