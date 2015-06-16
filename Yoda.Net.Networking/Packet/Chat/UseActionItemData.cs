namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class UseActionItemData : IPacket
    {
        private int _sequence;

        public UseActionItemData(int param1)
        {
            this._sequence = param1;
        }

        public int packetId
        {
            get
            {
                return 0x3a7;
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

