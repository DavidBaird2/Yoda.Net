namespace Yoda.Net.Networking.Packet.Info.scratch
{
    
    
    using System;

    public class OpenScratchData : IPacket
    {
        public int index;
        public string code;

        public int packetId
        {
            get
            {
                return PacketId.OPEN_SCRATCH;
            }
        }
        public OpenScratchData(string _code, int _index)
        {
            this.code = _code;
            this.index = _index;
            return;
        }

        public void readData(AmebaStream In)
        {
            code = In.readUTF();
            index = In.readByte();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(code);
            Out.writeByte((byte)index);
            return;
        }
    }
}

