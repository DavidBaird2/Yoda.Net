namespace Yoda.Net.Networking.Packet.Chat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    
    
    using Yoda.Net.Networking.Packet.Chat;

    public class MoveData : ICommandData, IEncrypted
    {
        public int x;
        public int y;
        public int z;

        public MoveData(int x = 0, int y = 0, int z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public MoveData()
        {
        }
        public int packetId
        {
            get
            {
                return PacketId.MOVE;
            }
        }

        public void readData(PiggStream In)
        {
            this.x = In.readShort();
            this.y = In.readShort();
            this.z = In.readShort();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeShort((short) this.x);
            Out.writeShort((short) this.y);
            Out.writeShort((short) this.z);
        }
    }
}

