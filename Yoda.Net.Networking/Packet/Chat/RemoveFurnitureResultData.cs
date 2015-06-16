namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class RemoveFurnitureResultData : IPacket
    {
        public int sequence;

        public int packetId
        {
            get
            {
                return 0x321;
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

