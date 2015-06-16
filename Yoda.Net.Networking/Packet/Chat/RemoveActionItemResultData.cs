namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class RemoveActionItemResultData : IPacket
    {
         public int sequence;
        public int actionItemType;


        public RemoveActionItemResultData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.REMOVE_ACTION_ITEM_RESULT;
            }
        }

        public void readData(AmebaStream In)
        {
            sequence = In.readInt();
            actionItemType = In.readByte();
        }

        public void writeData(AmebaStream Out)
        {
        }
    }
}

