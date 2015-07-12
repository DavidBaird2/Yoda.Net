namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class RemoveFurnitureResultData : ICommandData
    {
        public int sequence;

        public int packetId
        {
            get
            {
                return 0x321;
            }
        }

        public void readData(PiggStream In)
        {
            this.sequence = In.readInt();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(this.sequence);
        }
    }
}

