namespace Yoda.Net.Networking.Data.Room
{
    using System;


    public class PartData
    {
        //そのパーツに物を置けるか
        public bool attachable;
        //
        public int attachDirection = -1;
        public int height;
        public int index;
        public int rx;
        public int ry;
        //座れるか
        public bool sittable;
        public bool walkable;
        public sbyte wall;

        public Wall getWall()
        {
            return Wall.WALLS[wall];
        }
        public PartData clone()
        {
            return new PartData { height = this.height, walkable = this.walkable, attachable = this.attachable, sittable = this.sittable, attachDirection = this.attachDirection, rx = this.rx, ry = this.ry, index = this.index, wall = this.wall };
        }
        public void readData(PiggStream Om, bool attachDirection)
        {
            this.height = Om.readInt();
            this.attachable = Om.readBoolean();
            this.sittable = Om.readBoolean();
            this.walkable = Om.readBoolean();
            this.wall = Om.readByte();

            if (attachDirection) this.attachDirection = Om.readByte();

            this.rx = Om.readByte();
            this.ry = Om.readByte();
            //	this.orgSittable = this.sittable;
        }
        public void writeData(PiggStream Out, bool appendDirection)
        {

            Out.writeInt(height);
            Out.writeBoolean(attachable);
            Out.writeBoolean(sittable);
            Out.writeBoolean(walkable);
            Out.writeByte(wall);
            if (appendDirection)
                Out.writeByte((byte)attachDirection);
            Out.writeByte((byte)rx);
            Out.writeByte((byte)ry);
        }


    }
}

