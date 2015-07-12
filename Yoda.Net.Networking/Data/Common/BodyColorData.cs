namespace Yoda.Net.Networking.Data.Common
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

        public void readData(PiggStream In)
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

        public void setData(BodyColorData stream)
        {
            this.skin = stream.skin;
            this.hair = stream.hair;
            this.eyebrow = stream.eyebrow;
            this.eye = stream.eye;
            this.beard = stream.beard;
            this.lip = stream.lip;
            this.cheek = stream.cheek;
            this.eyeshadow = stream.eyeshadow;
        }

        public void writeData(PiggStream Out)
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

