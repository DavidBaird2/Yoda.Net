namespace Yoda.Net.Networking.Data.Room
{
    using System;

    public class PartData
    {
        public bool attachable;
        public int attachDirection = -1;
        public int height;
        public int index;
        public int rx;
        public int ry;
        public bool sittable;
        public bool walkable;
        public sbyte wall;

        public PartData clone()
        {
            return new PartData { height = this.height, walkable = this.walkable, attachable = this.attachable, sittable = this.sittable, attachDirection = this.attachDirection, rx = this.rx, ry = this.ry, index = this.index, wall = this.wall };
        }
    }
}

