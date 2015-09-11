namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class RemoveFurnitureData : ICommandData, IEncrypted
    {
        public int sequence;

        public RemoveFurnitureData()
        {
        }

        public RemoveFurnitureData(int sequence)
        {
            this.sequence = sequence;
        }

        public int packetId
        {
            get
            {
                return 800;
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

