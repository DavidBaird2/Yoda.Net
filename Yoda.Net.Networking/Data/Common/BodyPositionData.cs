namespace Yoda.Net.Networking.Data.Common
{
    
    using System;
    using System.Runtime.InteropServices;
    using Yoda.Net.Networking;

    public class BodyPositionData
    {
        public Point beard = new Point();
        public Point cheek = new Point();
        public Point eye = new Point();
        public Point eyebrow = new Point();
        public Point mole1 = new Point();
        public Point mole2 = new Point();
        public Point mouth = new Point();
        public Point nose = new Point();

        public void readData(AmebaStream In)
        {
            this.eye.x = In.readFloat();
            this.eye.y = In.readFloat();
            this.eyebrow.x = In.readFloat();
            this.eyebrow.y = In.readFloat();
            this.cheek.x = In.readFloat();
            this.cheek.y = In.readFloat();
            this.nose.x = In.readFloat();
            this.nose.y = In.readFloat();
            this.mouth.x = In.readFloat();
            this.mouth.y = In.readFloat();
            this.beard.x = In.readFloat();
            this.beard.y = In.readFloat();
            this.mole1.x = In.readFloat();
            this.mole1.y = In.readFloat();
            this.mole2.x = In.readFloat();
            this.mole2.y = In.readFloat();
        }

        public void setData(BodyPositionData Out)
        {
            this.eye = Out.eye;
            this.eyebrow = Out.eyebrow;
            this.cheek = Out.cheek;
            this.nose = Out.nose;
            this.mouth = Out.mouth;
            this.beard = Out.beard;
            this.mole1 = Out.mole1;
            this.mole2 = Out.mole2;
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeFloat(this.eye.x);
            Out.writeFloat(this.eye.y);
            Out.writeFloat(this.eyebrow.x);
            Out.writeFloat(this.eyebrow.y);
            Out.writeFloat(this.cheek.x);
            Out.writeFloat(this.cheek.y);
            Out.writeFloat(this.nose.x);
            Out.writeFloat(this.nose.y);
            Out.writeFloat(this.mouth.x);
            Out.writeFloat(this.mouth.y);
            Out.writeFloat(this.beard.x);
            Out.writeFloat(this.beard.y);
            Out.writeFloat(this.mole1.x);
            Out.writeFloat(this.mole1.y);
            Out.writeFloat(this.mole2.x);
            Out.writeFloat(this.mole2.y);
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Point
        {
            public Point(float x, float y)
            {
                this.x = x;
                this.y = y;
            }
            public float x;
            public float y;
        }
    }
}

