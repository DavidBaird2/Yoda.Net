﻿namespace Yoda.Net.Networking.Packet.Chat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    
    
    using Yoda.Net.Networking.Packet.Chat;
    public class MoveEndResultData : IPacket
    {
        public short dir;
        public string hexCode;
        public short x;
        public short y;
        public short z;
        public MoveEndResultData()
        {

        }
        public int packetId
        {
            get
            {
                return PacketId.MOVE_END_RESULT;
            }
        }

        public void readData(AmebaStream In)
        {
            this.hexCode = In.readUTFBytes(0x10);
            this.x = In.readShort();
            this.y = In.readShort();
            this.z = In.readShort();
            this.dir = In.readByte();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTFBytes(hexCode);
            Out.writeShort((short)this.x);
            Out.writeShort((short)this.y);
            Out.writeShort((short)this.z);
            Out.writeByte((byte)this.dir);
        }
    }
}

