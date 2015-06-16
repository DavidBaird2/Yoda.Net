namespace Yoda.Net.Data.Common
{
    
    using System;
    using Yoda.Net.Networking;

    public class BodyColorData
    {
        public short beard = 1;
        public short cheek = -1;
        public short eye = 0;
        public short eyebrow = 1;
        public short eyeshadow = -1;
        public short hair = 2;
        public short lip = -1;
        public short skin = 2;

        public void readData(AmebaStream In)
        {
            this.skin = In.readShort();
            this.hair = In.readShort();
            this.eyebrow = In.readShort();
            this.eye = In.readShort();
            this.beard = In.readShort();
            this.lip = In.readShort();
            this.cheek = In.readShort();
            this.eyeshadow = In.readShort();
        }

        public void setData(BodyColorData param1)
        {
            this.skin = param1.skin;
            this.hair = param1.hair;
            this.eyebrow = param1.eyebrow;
            this.eye = param1.eye;
            this.beard = param1.beard;
            this.lip = param1.lip;
            this.cheek = param1.cheek;
            this.eyeshadow = param1.eyeshadow;
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeShort(this.skin);
            Out.writeShort(this.hair);
            Out.writeShort(this.eyebrow);
            Out.writeShort(this.eye);
            Out.writeShort(this.beard);
            Out.writeShort(this.lip);
            Out.writeShort(this.cheek);
            Out.writeShort(this.eyeshadow);
        }
    }
}

