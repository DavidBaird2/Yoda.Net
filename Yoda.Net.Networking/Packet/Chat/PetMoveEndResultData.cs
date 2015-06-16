namespace Yoda.Net.Networking.Packet.Chat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    
    
    using Yoda.Net.Networking.Packet.Chat;
    public class PetMoveEndResultData : IPacket
    {
        public short dir;
        public int petId;
        public short x;
        public short y;
        public short z;

        public int packetId
        {
            get
            {
                return PacketId.PET_MOVE_END_RESULT;
            }
        }

        public void readData(AmebaStream In)
        {
            this.petId = In.readInt();
            this.x = In.readShort();
            this.y = In.readShort();
            this.z = In.readShort();
            this.dir = In.readByte();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeInt(petId);
            Out.writeShort((short)this.x);
            Out.writeShort((short)this.y);
            Out.writeShort((short)this.z);
            Out.writeByte((byte)this.dir);
        }
    }
}

