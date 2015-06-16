namespace Yoda.Net.Networking.Packet.Chat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    
    
    using Yoda.Net.Networking.Packet.Chat;
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
            return;
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(code);
            Out.writeUTF(message);
            Out.writeUTF(exceptionClass);
            Out.writeUTF(exceptionTrace);
            return;
        }
        public string toString()
        {
            //return "***** ERROR DATA *****\n" + code + "\n" + message + "\n" + exceptionClass + "\n" + exceptionTrace + "\n" + causePacketId + "\n";
            return "ERROR\n" + code + "\n" + message + "\n" + exceptionClass + "\n" + exceptionTrace + "\n" + causePacketId + "\n";
        }
    }
}

