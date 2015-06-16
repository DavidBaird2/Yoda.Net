namespace libPigg.net.info.user
{
    
    using System;
    
    using Yoda.Net.Networking.Packet.Info;
    using Yoda.Net.Networking.Packet.Data.common;
    using System.Drawing;
    using System.Collections;

    using System.Windows.Forms;
    using System.IO;
    using Yoda.Net.Networking;
    using Yoda.Net.Common;

    using Yoda.Net.Networking.Packet;

    public class DressupData : IPacket
    {
        public bool changedBody;
        public BodyColorData color;
        public ArrayList items;
        public BodyPartData part;
        public BodyPositionData position;
        public Bitmap thumbnail;
        public bool isFinishTutorial =true;
        public int packetId
        {
            get
            {
                return PacketId.DRESSUP;
            }
        }

        public Bitmap SetPixels(byte[] data)
        {

            AmebaStream Array = new AmebaStream(data);

            //大きさを指定してBitmapオブジェクトの作成
            Bitmap img = new Bitmap(40, 40);

            //imgのGraphicsオブジェクトを取得
            Graphics g = Graphics.FromImage(img);

            //白に塗りつぶす
            g.FillRectangle(Brushes.White, g.VisibleClipBounds);

            Random rnd = new Random();

            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    //色の作成
                    //   Array.readByte();
                    Color col = Color.FromArgb((byte)Array.readByte(), (byte)Array.readByte(), (byte)Array.readByte(), (byte)Array.readByte());
                    //1つのピクセルの色を変える
                    img.SetPixel(x, y, col);
                }
            }

            return img;
        }
        public byte[] GetPixels(Bitmap image)
        {
            AmebaStream Array = new AmebaStream();
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color col = image.GetPixel(x, y);
                    Array.writeByte(col.A);
                    Array.writeByte(col.R);
                    Array.writeByte(col.G);
                    Array.writeByte(col.B);
                   /* //色の作成
                    //   Array.readByte();
                    Color col = Color.FromArgb(Array.readByte(), Array.readByte(), Array.readByte(), Array.readByte());
                    //1つのピクセルの色を変える
                    img.SetPixel(x, i, col);*/
                }
            }
            Array.position = 0;
            byte[] cdata = Array.readBytes((int)Array.BaseStream.Length);

            return cdata;
        }
        public void readData(AmebaStream In)
        {


            int lengh = In.readShort();
            if (lengh != 0)
            {
                byte[] CompressedImage = In.readBytes(lengh);

                // 入出力用のストリームを生成します 
                FileCompressionUtility zlib = new FileCompressionUtility();
                byte[] body = zlib.uncompress(CompressedImage);

                Bitmap image = SetPixels(body);

                //  image.Save("test.bmp");
            }
            part = new BodyPartData();
            color = new BodyColorData();
            position = new BodyPositionData();
            items = new ArrayList();
            this.part.gender = In.readByte();
            this.part.readData(In);
            this.color.readData(In);
            this.position.readData(In);
            int count = In.readByte();
            for (int i = 0; i < count; i++)
            {
                UserItemData data = new UserItemData();
                data.id = In.readInt();
                items.Add(data);
            }
            this.changedBody = In.readBoolean();
            isFinishTutorial = In.readBoolean();
        }
        public static Bitmap BytesToBitmap(byte[] byteArray)
        {


            using (MemoryStream ms = new MemoryStream(byteArray))
            {


                Bitmap img = (Bitmap)Image.FromStream(ms);


                return img;


            }

        }


        public void writeData(AmebaStream Out)
        {
            UserItemData data = null;
            if (this.thumbnail == null)
            {
                Out.writeShort(0);
            }
            else
            {



                //サムネールイメージを作成大きさを100x100ピクセルにする
                Image myThumbnail =
                    this.thumbnail.GetThumbnailImage(40, 40, null, IntPtr.Zero);
                byte[] imgdata = GetPixels((Bitmap)myThumbnail);
                FileCompressionUtility util = new FileCompressionUtility();
                byte[] img = util.Compress(imgdata);
                Out.writeShort((short)img.Length);
                Out.writeBytes(img);
            }
            Out.writeByte(Convert.ToByte(this.part.gender));
            this.part.writeData(Out);
            this.color.writeData(Out);
            this.position.writeData(Out);
            if (this.items.Count > 120)
            {
                Out.writeByte(120);
            }
            else
            {
                Out.writeByte((byte)this.items.Count);
            }
            for (int i = 0; i < this.items.Count; i++)
            {
                data = this.items[i] as UserItemData;
                Out.writeInt(data.id);

                if (i == 120)
                    break;
            }
            Out.writeBoolean(this.changedBody);
            Out.writeBoolean(this.isFinishTutorial);
        }
    }
}

