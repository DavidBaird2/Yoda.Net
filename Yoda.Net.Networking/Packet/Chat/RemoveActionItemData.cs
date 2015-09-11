namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class RemoveActionItemData : ICommandData
    {
        public RemoveActionItemData()
        {
        }
        private int _sequence;

        public RemoveActionItemData(int _sequence)
        {
            this._sequence = _sequence;
        }

        public int packetId
        {
            get
            {
                return 930;
            }
        }

        public void readData(PiggStream In)
        {
            _sequence = In.readInt();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(this._sequence);
        }
    }
}

