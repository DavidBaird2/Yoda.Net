namespace Yoda.Net.Networking.Packet.Chat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    
    
    using Yoda.Net.Networking.Packet.Chat;

    public class MoveResultData : IPacket, IEncrypted
    {
        public int z;
        public int x;
        public int y;
        public string code;
        public MoveResultData(int param1 = 0, int param2 = 0, int param3 = 0)
        {
            this.x = param1;
            this.y = param2;
            this.z = param3;
        }
        public MoveResultData()
        {

        }
        public int packetId
        {
            get
            {
                return PacketId.MOVE_RESULT;
            }
        }

        public void readData(AmebaStream In)
        {
            code = In.readUTFBytes(16);
            x = In.readShort();
            y = In.readShort();
            z = In.readShort();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTFBytes(code);
            Out.writeShort((short) this.x);
            Out.writeShort((short) this.y);
            Out.writeShort((short) this.z);
        }
    }
}

