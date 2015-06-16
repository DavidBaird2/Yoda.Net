namespace Yoda.Net.Networking.Packet.Chat
{
    

    using System;
    

    public class ForceMoveResultData : IPacket
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

        public void readData(AmebaStream In)
        {
            userCode = In.readUTF();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(userCode);
        }
    }
}
