namespace Yoda.Net.Networking.Packet.Chat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    
    
    using Yoda.Net.Networking.Packet.Chat;
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
            var num = In.readShort();
            if (num >= 0)
            {
                code = In.readUTFBytes(num);
            }
            num = In.readShort();
            if (num >= 0)
            {
                message = In.readUTFBytes(num);
            }
            num = In.readShort();
            if (num >= 0)
            {
                exceptionClass = In.readUTFBytes(num);
            }
            num = In.readShort();
            if (num >= 0)
            {
                exceptionTrace = In.readUTFBytes(num);
            }
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(code);
            Out.writeUTF(message);
            Out.writeUTF(exceptionClass);
            Out.writeUTF(exceptionTrace);
            return;
        }
        public string toString()
        {
            return "ERROR\n" + code + "\n" + message + "\n" + exceptionClass + "\n" + exceptionTrace + "\n" + causePacketId + "\n";
        }
    }
}

