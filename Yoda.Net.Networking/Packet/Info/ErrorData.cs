namespace Yoda.Net.Networking.Packet.Info
{
    

    using System;
    using System.Runtime.InteropServices;
    

    public class ErrorData : ICommandData
    {
        public string message;
        public string exceptionClass;
        public string code;
        public string exceptionTrace;
        public int causePacketId;

        public ErrorData()
        {
            return;
        }

        public int packetId
        {
            get
            {
                return PacketId.ERROR;
            }
        }

        public void readData(PiggStream In)
        {
            var len = In.readShort();
            if (len >= 0)
            {
                code = In.readUTFBytes(len);
            }
            len = In.readShort();
            if (len >= 0)
            {
                message = In.readUTFBytes(len);
            }
            len = In.readShort();
            if (len >= 0)
            {
                exceptionClass = In.readUTFBytes(len);
            }
            len = In.readShort();
            if (len >= 0)
            {
                exceptionTrace = In.readUTFBytes(len);
            }
            causePacketId = In.readShort();
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(code);
            Out.writeUTF(message);
            Out.writeUTF(exceptionClass);
            Out.writeUTF(exceptionTrace);
            Out.writeShort((short)causePacketId);
            return;
        }
        public string toString()
        {
            return "ERROR\n" + code + "\n" + message + "\n" + exceptionClass + "\n" + exceptionTrace + "\n" + causePacketId + "\n";
        }
    }
}

