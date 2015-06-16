namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class UseActionItemResultData : IPacket
    {
        public int sequence;
        public string userCode;
        public UseActionItemResultData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.USE_ACTION_ITEM_RESULT;
            }
        }

        public void readData(AmebaStream In)
        {
            userCode = In.readUTF();
            sequence = In.readInt();
        }

        public void writeData(AmebaStream Out)
        {
        }
    }
}

