namespace Yoda.Net.Networking.Data.Room
{
    
    using System;

    public class PlacePet
    {
        public short direction;
        public int petId;
        public bool sleeping;
        public short x;
        public short y;
        public short z;

        public void readData(AmebaStream In)
        {
            this.petId = In.readInt();
            this.x = In.readShort();
            this.y = In.readShort();
            this.z = In.readShort();
            this.direction = In.readByte();
            this.sleeping = In.readBoolean();
        }
    }
}

