namespace Yoda.Net.Networking.Packet.Info.scratch
{

    using System;

    public class ChooseScratchData : IPacket
    {
        public string code;

        public int packetId
        {
            get
            {
                return PacketId.CHOOSE_SCRATCH;
            }
        }
        public ChooseScratchData(string _code)
        {
            this.code = _code;
            return;
        }

        public void readData(AmebaStream In)
        {
            code = In.readUTF();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(code);
            return;
        }
    }
}

