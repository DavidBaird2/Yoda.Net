namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class RemoveActionItemResultData : ICommandData
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

        public void readData(PiggStream In)
        {
            sequence = In.readInt();
            actionItemType = In.readByte();
        }

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
        }
    }
}

