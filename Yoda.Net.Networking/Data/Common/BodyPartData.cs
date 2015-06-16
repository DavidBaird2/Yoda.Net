namespace Yoda.Net.Data.Common
{
    
    using System;
    using Yoda.Net.Networking;

    public class BodyPartData
    {
        public short eye;
        public short eyebrow;
        public short face;
        public short gender;
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
        public void readData(AmebaStream In,bool appendGender = false)
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

        public void setData(BodyPartData param1)
        {
            this.gender = param1.gender;
            this.beard = param1.beard;
            this.eye = param1.eye;
            this.eyebrow = param1.eyebrow;
            this.face = param1.face;
            this.hairBack = param1.hairBack;
            this.hairFront = param1.hairFront;
            this.mole1 = param1.mole1;
            this.mole2 = param1.mole2;
            this.mouth = param1.mouth;
            this.nose = param1.nose;
        }
        /// <summary>
        /// clientのwriteの場合は先頭にgenderを付け加える必要がある
        /// </summary>
        public void writeData(AmebaStream Out,bool appendGender = false)
        {
            if (appendGender)
            {
                Out.writeBoolean(appendGender);
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

