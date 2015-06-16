namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class RemoveFurnitureData : IPacket, IEncrypted
    {
        public int sequence;

        public RemoveFurnitureData()
        {
        }

        public RemoveFurnitureData(int param1)
        {
            this.sequence = param1;
        }

        public int packetId
        {
            get
            {
                return 800;
            }
        }

        public void readData(AmebaStream In)
        {
            this.sequence = In.readInt();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeInt(this.sequence);
        }
    }
}

