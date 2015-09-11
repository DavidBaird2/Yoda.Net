namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class PetActionData : ICommandData
    {
        public PetActionData()
        {
        }
        private string _actionCode;
        private int _petId;

        public PetActionData(int petId, string actionCode)
        {
            this._petId = petId;
            this._actionCode = actionCode;
        }

        public int packetId
        {
            get
            {
                return 0x90c;
            }
        }

        public void readData(PiggStream In)
        {
            throw new NotImplementedException();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(this._petId);
            Out.writeUTF(this._actionCode);
        }
    }
}

