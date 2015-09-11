namespace Yoda.Net.Networking.Packet.Info.Scratch
{
    
    
    using System;

    public class OpenScratchData : ICommandData
    {
        public OpenScratchData()
        {
        }
        public int index;
        public string code;

        public int packetId
        {
            get
            {
                return PacketId.OPEN_SCRATCH;
            }
        }
        public OpenScratchData(string code, int index)
        {
            this.code = code;
            this.index = index;
            return;
        }

        public void readData(PiggStream In)
        {
            code = In.readUTF();
            index = In.readByte();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(code);
            Out.writeByte((byte)index);
            return;
        }
    }
}

