namespace Yoda.Net.Networking.Packet.Info.FootPrint
{
    
    
    using System;
    using System.Collections;
    public class LeaveFootPrintData : ICommandData, IEncrypted
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

        public void readData(PiggStream In)
        {
            code = In.readUTF();
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(code);
            return;
        }
    }
}

