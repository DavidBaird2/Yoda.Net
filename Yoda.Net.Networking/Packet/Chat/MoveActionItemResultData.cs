namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class MoveActionItemResultData : ICommandData
    {
        public string userCode;
        public int sequence;
        public int x;
        public int y;
        public int z;

        public int packetId
        {
            get
            {
                return PacketId.MOVE_ACTION_ITEM_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            userCode = In.readUTF();
            sequence = In.readInt();
            x = In.readShort();
            y = In.readShort();
            z = In.readShort();
        }

        public void writeData(PiggStream Out)
        {

        }
    }
}

