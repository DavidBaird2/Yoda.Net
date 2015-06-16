namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class MoveFurnitureResultData : IPacket
    {
        public int dir;
        public int sequence;
        public int x;
        public int y;
        public int z;

        public int packetId
        {
            get
            {
                return 0x311;
            }
        }

        public void readData(AmebaStream In)
        {
            this.sequence = In.readInt();
            this.dir = In.readByte();
            this.x = In.readInt();
            this.y = In.readInt();
            this.z = In.readInt();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeInt(this.sequence);
            Out.writeByte((byte) this.dir);
            Out.writeInt(this.x);
            Out.writeInt(this.y);
            Out.writeInt(this.z);
        }
    }
}

