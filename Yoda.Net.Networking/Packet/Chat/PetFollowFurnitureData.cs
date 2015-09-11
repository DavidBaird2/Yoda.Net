namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class PetFollowFurnitureData : ICommandData
    {
        public PetFollowFurnitureData()
        {
        }
        private int _petId;
        private int _sequence;
        private string _actionCode;
        private int _posx;
        private int _posy;
        private int _posz;


        public PetFollowFurnitureData(int petId, int sequence, int posy, int posx, int posz, string actionCode = "sleep")
        {
            this._petId = petId;
            this._sequence = sequence;
            this._actionCode = actionCode;
            this._posx = posx;
            this._posy = posy;
            this._posz = posz;
        }

        public int packetId
        {
            get
            {
                return PacketId.PET_FURNITURE_ACTION;
            }
        }

        public void readData(PiggStream In)
        {
            throw new NotImplementedException();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(this._petId);
            Out.writeInt(this._sequence);
            Out.writeUTF(this._actionCode);
            Out.writeInt(this._posx);
            Out.writeInt(this._posy);
            Out.writeInt(this._posz);
        }
    }
}

