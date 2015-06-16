namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class PetPlaceData : IPacket
    {
          private int _petId;
        private int _x;
        private int _y;
        private int _z;
        private int _dir;


        public PetPlaceData(int param1, int param2,int  param3,int  param4,int  param5)
        {
         this._petId = param1;
            this._x = param2;
            this._y = param3;
            this._z = param4;
            this._dir = param5;
        }

        public int packetId
        {
            get
            {
                return PacketId.PET_PLACE;
            }
        }

        public void readData(AmebaStream In)
        {
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeInt(this._petId);
            Out.writeShort((short)this._x);
            Out.writeShort((short)this._y);
            Out.writeShort((short)this._z);
            Out.writeByte((byte)this._dir);
        }
    }
}

