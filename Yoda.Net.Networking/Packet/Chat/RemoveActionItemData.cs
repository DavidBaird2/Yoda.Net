namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class RemoveActionItemData : IPacket
    {
        private int _sequence;

        public RemoveActionItemData(int param1)
        {
            this._sequence = param1;
        }

        public int packetId
        {
            get
            {
                return 930;
            }
        }

        public void readData(AmebaStream In)
        {
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeInt(this._sequence);
        }
    }
}

