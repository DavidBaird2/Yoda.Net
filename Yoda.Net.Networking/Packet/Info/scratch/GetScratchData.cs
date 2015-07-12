namespace Yoda.Net.Networking.Packet.Info.scratch
{
    
    
    using System;

    public class GetScratchData : ICommandData
    {
        public GetScratchData()
        {
        }
        public string code;

        public int packetId
        {
            get
            {
                return PacketId.GET_SCRACTH;
            }
        }
        public GetScratchData(string code = "")
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

