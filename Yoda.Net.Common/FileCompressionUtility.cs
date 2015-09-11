using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using zlib;


namespace Yoda.Net.Common
{
    public class FileCompressionUtility
    {
        public FileCompressionUtility()
        {
        }
        public static void CopyStream(System.IO.Stream input, System.IO.Stream output)
        {
            byte[] buffer = new byte[2000];
            int len;
            while ((len = input.Read(buffer, 0, 2000)) > 0)
            {
                output.Write(buffer, 0, len);
                output.Flush();
            }
        }
        public byte[] Compress(byte[] data)
        {
            MemoryStream inputStream = new MemoryStream(data);
            MemoryStream OutputStream = new MemoryStream();
            ZOutputStream outZStream = new ZOutputStream(OutputStream, zlibConst.Z_BEST_COMPRESSION);
            try
            {
                CopyStream(inputStream, outZStream);
            }
            finally
            {
                // OutputStream.Close();
                outZStream.Close();
            }
            return OutputStream.ToArray();
        }
        public byte[] Compress2(byte[] data)
        {
            MemoryStream inputStream = new MemoryStream(data);
            MemoryStream OutputStream = new MemoryStream();
            ZOutputStream outZStream = new ZOutputStream(OutputStream, zlibConst.Z_BEST_SPEED);
            try
            {
                CopyStream(inputStream, outZStream);
            }
            finally
            {
                // OutputStream.Close();
                outZStream.Close();
            }
            return OutputStream.ToArray();
        }
        public byte[] uncompress(byte[] idata)
        {
            int data = 0;
            int stopByte = -1;
            MemoryStream inputStream = new MemoryStream(idata);
            MemoryStream OutputStream = new MemoryStream();
            ZInputStream inZStream = new ZInputStream(inputStream);
            while (stopByte != (data = inZStream.Read()))
            {
                byte _dataByte = (byte)data;
                OutputStream.WriteByte(_dataByte);
            }
            inZStream.Close();
            OutputStream.Close();
            return OutputStream.ToArray();
        }
    }
}
