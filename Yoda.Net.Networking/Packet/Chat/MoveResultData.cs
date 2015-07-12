namespace Yoda.Net.Networking.Packet.Chat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    
    
    using Yoda.Net.Networking.Packet.Chat;

    public class MoveResultData : ICommandData
    {
        public int z;
        public int x;
        public int y;
        public string code;
        public MoveResultData(int x = 0, int y = 0, int z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
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

        public void readData(PiggStream In)
        {
            code = In.readUTFBytes(16);
            x = In.readShort();
            y = In.readShort();
            z = In.readShort();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTFBytes(code);
            Out.writeShort((short) this.x);
            Out.writeShort((short) this.y);
            Out.writeShort((short) this.z);
        }
    }
}

