namespace Yoda.Net.Networking
{

    using System;
    using System.IO;
    using System.Text;

    public class PiggStream : IDisposable
    {
        private Stream stream;

        public PiggStream()
        {
            this.stream = new MemoryStream();
        }

        public PiggStream(byte[] value)
        {
            this.stream = new MemoryStream();
            stream.Write(value, 0, value.Length);
            this.position = 0;
        }

        public byte[] ReadBytes(int count)
        {
            byte[] ret = new byte[count];
            int index = 0;
            int read = stream.Read(ret, index, count - index);
            return ret;
        }

        public void Write(byte[] data)
        {
            stream.Write(data, 0, data.Length);
        }

        public byte[] toArray()
        {
            return ((MemoryStream)stream).ToArray();
        }

        public byte[] toArrayLast()
        {
            return ReadBytes((int)(stream.Length - stream.Position));

        }

        public void readBytes(PiggStream output)
        {
            output.writeBytes(ReadBytes((int)(stream.Length - stream.Position)));
            output.BaseStream.Position = 0;
        }

        public byte[] readBytes(int count)
        {
            byte[] bytes = this.ReadBytes(count);
            return bytes;
        }

        public void writeDate(DateTime date)
        {
            this.writeDouble(date.Subtract(DateTime.Parse("1970/1/1 09:00")).TotalMilliseconds);
        }


        public byte[] longToByte(long value, int len)
        {
            byte[] bA = BitConverter.GetBytes(value);
            Array.Resize(ref bA, len);
            Array.Reverse(bA);
            return bA;
        }

        public long byteToLong(byte[] buffer)
        {
            Array.Reverse(buffer);
            Array.Resize(ref buffer, 8);
            var ret = BitConverter.ToInt64(buffer, 0);
            return ret;
        }

        public bool readBoolean()
        {
            byte[] bytes = ReadBytes(1);

            return Convert.ToBoolean(bytes[0]);
        }

        public sbyte readByte()
        {
            byte[] bytes = ReadBytes(1);
            return unchecked((sbyte)bytes[0]);
        }

        public byte readUnsignedByte()
        {
            byte[] bytes = ReadBytes(1);
            return (byte)bytes[0];
        }

        public double readDouble()
        {
            byte[] bytes = ReadBytes(8);
            var value = BitConverter.Int64BitsToDouble(byteToLong(bytes));
            return value;
        }

        public float readFloat()
        {
            unsafe
            {
                int value = readInt();
                var floatValue = *(float*)&value;
                return floatValue;
            }
        }

        public int readInt()
        {
            return (int)byteToLong(ReadBytes(4));
        }

        public short readShort()
        {

            byte[] bytes = ReadBytes(2);
            return unchecked((short)byteToLong(bytes));
        }

        public uint readUnsignedInt()
        {

            byte[] bytes = ReadBytes(4);
            return unchecked((uint)byteToLong(bytes));
        }

        public string readUTF()
        {
            int num = this.readShort();
            byte[] bytes = ReadBytes(num);
            return Encoding.UTF8.GetString(bytes);
        }

        public string readUTFBytes(int length)
        {
            byte[] bytes = ReadBytes(length);
            return Encoding.UTF8.GetString(bytes);
        }

        public void writeBoolean(bool value)
        {
            byte[] bytes = longToByte(Convert.ToByte(value), 1);
            Write(bytes);
        }

        public void writeByte(byte value)
        {
            byte[] bytes = longToByte((byte)value, 1);
            Write(bytes);
        }
        public void writeByte(sbyte value)
        {
            byte[] bytes = longToByte(value, 1);
            Write(bytes);
        }
        public DateTime readTime()
        {
            DateTime time = DateTime.Parse("1970/1/1 09:00");
            return time.AddMilliseconds(readDouble());

        }
        public void writeBytes(byte[] value)
        {
            Write(value);
        }
        public void writeBytes(PiggStream Base, int start, int length)
        {
            byte[] buffer = new byte[length];
            Base.stream.Read(buffer, start, length);
            this.Write(buffer);
        }

        public void writeDouble(double value)
        {
            byte[] bytes = longToByte(BitConverter.DoubleToInt64Bits(value), 8);
            Write(bytes);
        }

        public void writeFloat(float value)
        {
            unsafe
            {
                writeUnsignedInt(*(uint*)&value);
            }
        }

        public void writeInt(int value)
        {
            byte[] bytes = longToByte(value, 4);
            Write(bytes);
        }

        public void writeShort(short value)
        {
            byte[] bytes = longToByte(value, 2);
            Write(bytes);
        }

        public void writeUnsignedInt(uint value)
        {
            byte[] bytes = longToByte(unchecked((uint)value), 4);
            Write(bytes);
        }

        public void writeUTF(string value)
        {

            if (value == null)
            {
                value = "";
            }
            byte[] bytes = Encoding.UTF8.GetBytes(value);
            writeShort((short)bytes.Length);
            Write(bytes);

        }

        public void writeUTFBytes(string value)
        {
            Write(Encoding.UTF8.GetBytes(value));
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

        public void Dispose()
        {
        }

        public void readBytes(PiggStream content, int p, int length)
        {
            throw new NotImplementedException();
        }
    }
}

