namespace Yoda.Net.Networking.Packet.Info
{
    

    using System;
    using System.Runtime.InteropServices;
    

    public class ErrorData : IPacket
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

        public void readData(AmebaStream In)
        {
            var _loc_2 = In.readShort();
            if (_loc_2 >= 0)
            {
                code = In.readUTFBytes(_loc_2);
            }
            _loc_2 = In.readShort();
            if (_loc_2 >= 0)
            {
                message = In.readUTFBytes(_loc_2);
            }
            _loc_2 = In.readShort();
            if (_loc_2 >= 0)
            {
                exceptionClass = In.readUTFBytes(_loc_2);
            }
            _loc_2 = In.readShort();
            if (_loc_2 >= 0)
            {
                exceptionTrace = In.readUTFBytes(_loc_2);
            }
            causePacketId = In.readShort();
            return;
        }

        public void writeData(AmebaStream Out)
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
          //  return "***** ERROR DATA *****\n" + code + "\n" + message + "\n" + exceptionClass + "\n" + exceptionTrace + "\n" + causePacketId + "\n";
            return "ERROR\n" + code + "\n" + message + "\n" + exceptionClass + "\n" + exceptionTrace + "\n" + causePacketId + "\n";
        }
    }
}

