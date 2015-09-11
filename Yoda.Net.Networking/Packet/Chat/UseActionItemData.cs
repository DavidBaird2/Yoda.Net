namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class UseActionItemData : ICommandData
    {
        public UseActionItemData()
        {
        }
        public int sequence;

        public UseActionItemData(int sequence)
        {
            this.sequence = sequence;
        }

        public int packetId
        {
            get
            {
                return 0x3a7;
            }
        }

        public void readData(PiggStream In)
        {
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(this.sequence);
        }
    }
}

