namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class PlaceActionItemData : IPacket ,IEncrypted,IncludeClientTime
    {
        public string _code;
        public int _x;
        public int _y;
        public int _z;

        public PlaceActionItemData(string code, int x, int y, int z)
        {
            this._code = code;
            this._x = x;
            this._y = y;
            this._z = z;
        }
        public PlaceActionItemData()
        {
        }
        public int packetId
        {
            get
            {
                return PacketId.PLACE_ACTION_ITEM;
            }
        }

        public void readData(AmebaStream In)
        {
            _code = In.readUTF();
            _x = In.readShort();
            _y = In.readShort();
            _z= In.readShort();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(_code);
            Out.writeShort((short)_x);
            Out.writeShort((short)_y);
            Out.writeShort((short)_z);
            return;
        }
    }
}

