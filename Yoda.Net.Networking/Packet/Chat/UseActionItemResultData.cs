namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class UseActionItemResultData : ICommandData
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

        public void readData(PiggStream In)
        {
            userCode = In.readUTF();
            sequence = In.readInt();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(userCode);
            Out.writeInt(sequence);
        }
    }
}

