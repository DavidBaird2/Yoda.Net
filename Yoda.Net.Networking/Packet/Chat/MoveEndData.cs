namespace Yoda.Net.Networking.Packet.Chat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    
    
    using Yoda.Net.Networking.Packet.Chat;

    public class MoveEndData : ICommandData, IEncrypted
    {
        public int dir;
        public int x;
        public int y;
        public int z;
        public MoveEndData()
        {

        }
        public MoveEndData(int x = 0, int y = 0, int z = 0, int dir = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.dir = dir;
        }

        public int packetId
        {
            get
            {
                return 0x202;
            }
        }

        public void readData(PiggStream In)
        {
            this.x = In.readShort();
            this.y = In.readShort();
            this.z = In.readShort();
            this.dir = In.readByte();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeShort((short) this.x);
            Out.writeShort((short) this.y);
            Out.writeShort((short) this.z);
            Out.writeByte((byte) this.dir);
        }
    }
}

