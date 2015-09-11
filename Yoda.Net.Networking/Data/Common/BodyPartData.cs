namespace Yoda.Net.Networking.Data.Common
{
    
    using System;
    using Yoda.Net.Networking;

    public class BodyPartData
    {
        public short eye;
        public short eyebrow;
        public short face;
        public sbyte gender;
        public short hairBack;
        public short hairFront;
        public short beard = -1;
        public short mole1 = -1;
        public short mole2 = -1;
        public short option = -1;
        public short mouth;
        public short nose;

        /// <summary>
        /// clientのwriteの場合は先頭にgenderがあるのでreadの際注意が必要
        /// </summary>
        public void readData(PiggStream In,bool appendGender = false)
        {
            if (appendGender)
            {
                this.gender = In.readByte();
            }
            this.face = In.readShort();
            this.hairFront = In.readShort();
            this.hairBack = In.readShort();
            this.eye = In.readShort();
            this.eyebrow = In.readShort();
            this.nose = In.readShort();
            this.mouth = In.readShort();
            this.beard = In.readShort();
            this.mole1 = In.readShort();
            this.mole2 = In.readShort();
            this.option = In.readShort();
        }

        public void setData(BodyPartData stream)
        {
            this.gender = stream.gender;
            this.beard = stream.beard;
            this.eye = stream.eye;
            this.eyebrow = stream.eyebrow;
            this.face = stream.face;
            this.hairBack = stream.hairBack;
            this.hairFront = stream.hairFront;
            this.mole1 = stream.mole1;
            this.mole2 = stream.mole2;
            this.mouth = stream.mouth;
            this.nose = stream.nose;
        }
        /// <summary>
        /// clientのwriteの場合は先頭にgenderを付け加える必要がある
        /// </summary>
        public void writeData(PiggStream Out,bool appendGender = false)
        {
            if (appendGender)
            {
                Out.writeByte((sbyte)gender);
            }
            Out.writeShort(this.face);
            Out.writeShort(this.hairFront);
            Out.writeShort(this.hairBack);
            Out.writeShort(this.eye);
            Out.writeShort(this.eyebrow);
            Out.writeShort(this.nose);
            Out.writeShort(this.mouth);
            Out.writeShort(this.beard);
            Out.writeShort(this.mole1);
            Out.writeShort(this.mole2);
            Out.writeShort(this.option);
        }
    }
}

