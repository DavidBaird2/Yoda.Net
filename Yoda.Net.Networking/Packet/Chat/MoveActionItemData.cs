namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class MoveActionItemData : ICommandData, IEncrypted, IncludeClientTime
    {
        public int sequence;
        public int x;
        public int y;
        public int z;

        public int packetId
        {
            get
            {
                return PacketId.MOVE_ACTION_ITEM;
            }
        }

        public void readData(PiggStream In)
        {
            sequence = In.readInt();
            x = In.readShort();
            y = In.readShort();
            z = In.readShort();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt((short)sequence);
            Out.writeShort((short)x);
            Out.writeShort((short)y);
            Out.writeShort((short)z);
        }
    }
}

