namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;
    using System.Runtime.InteropServices;

    public class MoveFurnitureData : ICommandData, IEncrypted
    {
        public int dir;
        public int sequence;
        public int x;
        public int y;
        public int z;

        public MoveFurnitureData()
        {
        }

        public MoveFurnitureData(int sequence = 0, int x = 0, int y = 0, int z = 0, int dir = 0)
        {
            this.sequence = sequence;
            this.x = x;
            this.y = y;
            this.z = z;
            this.dir = dir;
        }

        public int packetId
        {
            get
            {
                return 0x310;
            }
        }

        public void readData(PiggStream In)
        {
            this.sequence = In.readInt();
            this.dir = In.readByte();
            this.x = In.readInt();
            this.y = In.readInt();
            this.z = In.readInt();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(this.sequence);
            Out.writeByte((byte) this.dir);
            Out.writeInt(this.x);
            Out.writeInt(this.y);
            Out.writeInt(this.z);
        }
    }
}

