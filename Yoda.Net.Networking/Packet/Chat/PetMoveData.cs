namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class PetMoveData : IPacket
    {
        private int _petId;
        private int _x;
        private int _y;
        private int _z;

        public PetMoveData(int petId, int x, int y, int z)
        {
            this._petId = petId;
            this._x = x;
            this._y = y;
            this._z = z;
        }

        public int packetId
        {
            get
            {
                return PacketId.PET_MOVE;
            }
        }

        public void readData(AmebaStream In)
        {
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeInt(this._petId);
            Out.writeShort((short) this._x);
            Out.writeShort((short) this._y);
            Out.writeShort((short) this._z);

        }
    }
}

