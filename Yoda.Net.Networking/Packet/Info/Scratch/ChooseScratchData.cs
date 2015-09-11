namespace Yoda.Net.Networking.Packet.Info.Scratch
{

    using System;

    public class ChooseScratchData : ICommandData
    {
        public ChooseScratchData()
        {
        }
        public string code;

        public int packetId
        {
            get
            {
                return PacketId.CHOOSE_SCRATCH;
            }
        }
        public ChooseScratchData(string code)
        {
            this.code = code;
            return;
        }

        public void readData(PiggStream In)
        {
            code = In.readUTF();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(code);
            return;
        }
    }
}

