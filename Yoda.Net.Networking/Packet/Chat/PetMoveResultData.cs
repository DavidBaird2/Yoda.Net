namespace Yoda.Net.Networking.Packet.Chat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    
    
    using Yoda.Net.Networking.Packet.Chat;
    public class PetMoveResultData : IPacket
    {
                public bool requireEnd;
        public int petId;
        public short x;
        public short y;
        public short z;

        public int packetId
        {
            get
            {
                return PacketId.PET_MOVE_RESULT;
            }
        }

        public void readData(AmebaStream In)
        {
            this.petId = In.readInt();
            this.x = In.readShort();
            this.y = In.readShort();
            this.z = In.readShort();
            requireEnd = In.readBoolean();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeInt(petId);
            Out.writeShort((short)this.x);
            Out.writeShort((short)this.y);
            Out.writeShort((short)this.z);
            Out.writeBoolean(requireEnd);
        }
    }
}

