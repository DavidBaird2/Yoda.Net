namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class PetMoveEndData : ICommandData
    {

        public PetMoveEndData()
        {

        }
        public PetMoveEndData(int petId, short x, short y, short z, sbyte dir)
        {
            this.petId = petId;
            this.x = x;
            this.y = y;
            this.z = z;
            this.dir = dir;
        }

        public int packetId
        {
            get
            {
                return 0x906;
            }
        }

        public void readData(PiggStream In)
        {
            petId = In.readInt();
            x = In.readShort();
            y = In.readShort();
            z = In.readShort();
            dir = In.readByte();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(this.petId);
            Out.writeShort((short) this.x);
            Out.writeShort((short) this.y);
            Out.writeShort((short) this.z);
            Out.writeByte((sbyte) this.dir);
        }

        public int petId { get; set; }

        public short x { get; set; }

        public short y { get; set; }

        public short z { get; set; }

        public sbyte dir { get; set; }
    }
}

