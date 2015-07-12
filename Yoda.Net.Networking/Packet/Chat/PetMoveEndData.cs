namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class PetMoveEndData : ICommandData
    {
        private int _dir;
        private int _petId;
        private int _x;
        private int _y;
        private int _z;
        public PetMoveEndData()
        {

        }
        public PetMoveEndData(int petId, int x, int y, int z, int dir)
        {
            this._petId = petId;
            this._x = x;
            this._y = y;
            this._z = z;
            this._dir = dir;
        }

        public int packetId
        {
            get
            {
                return 0x906;
            }
        }

        public void readData(PiggStream In)
        {
            throw new NotImplementedException();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(this._petId);
            Out.writeShort((short) this._x);
            Out.writeShort((short) this._y);
            Out.writeShort((short) this._z);
            Out.writeByte((byte) this._dir);
        }
    }
}

