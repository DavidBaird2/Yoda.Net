namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class PetFollowFurnitureData : IPacket
    {
        private int _petId;
        private int _sequence;
        private string _actionCode;
        private int _posx;
        private int _posy;
        private int _posz;


        public PetFollowFurnitureData(int param1,int param2,int param3, int param4,int  param5, string param6 = "sleep")
        {
            this._petId = param1;
            this._sequence = param2;
            this._actionCode = param6;
            this._posx = param3;
            this._posy = param4;
            this._posz = param5;
        }

        public int packetId
        {
            get
            {
                return PacketId.PET_FURNITURE_ACTION;
            }
        }

        public void readData(AmebaStream In)
        {
        }

        public void writeData(AmebaStream Out)
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

