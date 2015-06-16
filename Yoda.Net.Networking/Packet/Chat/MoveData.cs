namespace Yoda.Net.Networking.Packet.Chat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    
    
    using Yoda.Net.Networking.Packet.Chat;

    public class MoveData : IPacket, IEncrypted
    {
        public int x;
        public int y;
        public int z;

        public MoveData(int param1 = 0, int param2 = 0, int param3 = 0)
        {
            this.x = param1;
            this.y = param2;
            this.z = param3;
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

        public void readData(AmebaStream In)
        {
            this.x = In.readShort();
            this.y = In.readShort();
            this.z = In.readShort();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeShort((short) this.x);
            Out.writeShort((short) this.y);
            Out.writeShort((short) this.z);
        }
    }
}

