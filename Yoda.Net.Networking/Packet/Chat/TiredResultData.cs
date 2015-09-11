namespace Yoda.Net.Networking.Packet.Chat
{


    using System;

    public class TiredResultData : ICommandData
    {
        public TiredResultData()
        {
        }
        private int level;

        public string userCode { get; set; }
        public TiredResultData(int level)
        {
            this.level = level;
        }

        public int packetId
        {
            get
            {
                return PacketId.TIRED_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            this.userCode = In.readUTF();
            this.level = In.readByte();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(userCode);
            Out.writeByte((byte)this.level);
        }

    }

}