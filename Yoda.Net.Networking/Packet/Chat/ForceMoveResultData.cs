namespace Yoda.Net.Networking.Packet.Chat
{
    

    using System;
    

    public class ForceMoveResultData : ICommandData
    {
        public string userCode;

        public ForceMoveResultData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.FORCE_MOVE_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            userCode = In.readUTF();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(userCode);
        }
    }
}
