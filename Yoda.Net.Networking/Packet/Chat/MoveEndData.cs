namespace Yoda.Net.Networking.Packet.Chat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    
    
    using Yoda.Net.Networking.Packet.Chat;

    public class MoveEndData : IPacket, IEncrypted
    {
        public int dir;
        public int x;
        public int y;
        public int z;

        public MoveEndData(int param1 = 0, int param2 = 0, int param3 = 0, int param4 = 0)
        {
            this.x = param1;
            this.y = param2;
            this.z = param3;
            this.dir = param4;
        }

        public int packetId
        {
            get
            {
                return 0x202;
            }
        }

        public void readData(AmebaStream In)
        {
            this.x = In.readShort();
            this.y = In.readShort();
            this.z = In.readShort();
            this.dir = In.readByte();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeShort((short) this.x);
            Out.writeShort((short) this.y);
            Out.writeShort((short) this.z);
            Out.writeByte((byte) this.dir);
        }
    }
}

