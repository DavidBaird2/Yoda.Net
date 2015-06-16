namespace Yoda.Net.Networking.Packet.Info.footprint
{
    
    
    using System;
    using System.Collections;
    public class LeaveFootPrintData : IPacket, IEncrypted
    {
        public string code;
        public LeaveFootPrintData()
        {
        }
        public LeaveFootPrintData(string code)
        {
            this.code = code;
        }
        public int packetId
        {
            get
            {
                return PacketId.LEAVE_FOOTPRINT;
            }
        }

        public void readData(AmebaStream In)
        {
            code = In.readUTF();
            return;
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(code);
            return;
        }
    }
}

