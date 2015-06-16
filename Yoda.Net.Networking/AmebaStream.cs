namespace Yoda.Net.Networking
{
    using MiscUtil.Conversion;
    using MiscUtil.IO;
    using System;
    using System.IO;
    using System.Text;

    public class AmebaStream
    {
        private EndianBinaryReader BinReader;
        private EndianBinaryWriter BinWriter;
        private Stream stream;


        public AmebaStream()
        {
            this.stream = new MemoryStream();
            this.BinWriter = new EndianBinaryWriter(EndianBitConverter.Big, this.stream, Encoding.UTF8);
            this.BinReader = new EndianBinaryReader(EndianBitConverter.Big, this.stream, Encoding.UTF8);
        }

        public byte[] toArray()
        {
            return ((MemoryStream)stream).ToArray();

        }
        public byte[] toArrayLast()
        {
            return BinReader.ReadBytes((int)(stream.Length - stream.Position));

        }


        public AmebaStream(byte[] value)
        {
            this.stream = new MemoryStream();
            this.BinWriter = new EndianBinaryWriter(EndianBitConverter.Big, this.stream, Encoding.UTF8);
            this.BinReader = new EndianBinaryReader(EndianBitConverter.Big, this.stream, Encoding.UTF8);
            BinWriter.Write(value);
            this.position = 0;
        }
        public AmebaStream(byte[] value, int startindex)
        {
            this.stream = new MemoryStream(value, startindex, value.Length - startindex);
            this.BinWriter = new EndianBinaryWriter(EndianBitConverter.Big, this.stream, Encoding.UTF8);
            this.BinReader = new EndianBinaryReader(EndianBitConverter.Big, this.stream, Encoding.UTF8);
        }
        public void close()
        {
            this.BinWriter.Dispose();
            this.BinReader.Dispose();
            this.stream.Dispose();
        }

        public bool readBoolean()
        {
            return this.BinReader.ReadBoolean();
        }
        public void readBytes(AmebaStream output)
        {
            output.writeBytes(BinReader.ReadBytes((int)(stream.Length - stream.Position)));
            output.BaseStream.Position = 0;
        }
        public sbyte readByte()
        {
            return this.BinReader.ReadSByte();
        }
        public byte readUnsignedByte()
        {
            return this.BinReader.ReadByte();
        }
        public byte[] readBytes(int count)
        {
            long postion = this.BinReader.BaseStream.Position;
            byte[] data = this.BinReader.ReadBytes(count);
            this.BinReader.BaseStream.Position = position;
            return data;
        }

        public double readDouble()
        {
            return this.BinReader.ReadDouble();
        }

        public float readFloat()
        {
            return this.BinReader.ReadSingle();
        }

        public int readInt()
        {
            return this.BinReader.ReadInt32();
        }

        public short readShort()
        {
            return this.BinReader.ReadInt16();
        }

        public uint readUnsignedInt()
        {
            return this.BinReader.ReadUInt32();
        }

        public string readUTF()
        {
            string str2;
            try
            {
                int num = this.BinReader.ReadInt16();
                byte[] bytes = this.BinReader.ReadBytes(num);
                str2 = Encoding.UTF8.GetString(bytes);
            }
            catch
            {
                throw;
            }
            return str2;
        }

        public string readUTFBytes(int length)
        {
            byte[] bytes = this.BinReader.ReadBytes(length);
            return Encoding.UTF8.GetString(bytes);
        }

        public void writeBoolean(bool value)
        {
            this.BinWriter.Write(value);
        }

        public void writeByte(byte value)
        {
            this.BinWriter.Write(value);
        }
        public void writeByte(sbyte value)
        {
            this.BinWriter.Write(value);
        }

        public void writeBytes(byte[] value)
        {
            this.BinWriter.Write(value);
        }

        public void writeBytes(AmebaStream Base, int start, int length)
        {
            byte[] buffer = new byte[length];
            Base.stream.Read(buffer, start, length);
            this.BinWriter.Write(buffer);
        }

        public void writeDouble(double value)
        {
            this.BinWriter.Write(value);
        }

        public void writeDate(DateTime date)
        {
            this.writeDouble(date.Subtract(
                DateTime.Parse("1970/1/1 09:00")).TotalMilliseconds);
        }

        public void writeFloat(float value)
        {
            this.BinWriter.Write(value);
        }

        public void writeInt(int value)
        {
            this.BinWriter.Write(value);
        }

        public void writeShort(short value)
        {
            this.BinWriter.Write(value);
        }

        public float writeSingle()
        {
            return this.BinReader.ReadSingle();
        }

        public void writeUnsignedInt(uint value)
        {
            this.BinWriter.Write(value);
        }

        public void writeUTF(string value)
        {
            if (value == null)
            {
                value = "";
            }
            byte[] bytes = Encoding.UTF8.GetBytes(value);
            this.BinWriter.Write((short)bytes.Length);
            this.BinWriter.Write(bytes);
        }

        public void writeUTFBytes(string value)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(value);
            this.BinWriter.Write(bytes);
        }
        public string toHex()
        {
            return ToHexString(toArray());
        }
        public static string ToHexString(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
            {
                if (b < 16) sb.Append('0'); // 二桁になるよう0を追加
                sb.Append(Convert.ToString(b, 16));
            }
            return sb.ToString();
        }


        public Stream BaseStream
        {
            get
            {
                return this.stream;
            }
        }

        public long length
        {
            get
            {
                return this.stream.Length;
            }
        }

        public long position
        {
            get
            {
                return this.stream.Position;
            }
            set
            {
                this.stream.Position = value;
            }
        }
    }
}

