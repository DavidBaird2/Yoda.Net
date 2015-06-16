namespace Yoda.Net.Networking.Packet.Info.beginnershop
{
    
    
    using System;


    public class GetBeginnerShopData : IPacket, IEncrypted
    {
        public string _shopCode;

        public GetBeginnerShopData()
        {

        }
        public GetBeginnerShopData(string param2)
        {
            this._shopCode = param2;
        }

        public int packetId
        {
            get
            {
                return PacketId.GET_BEGINNER_SHOP;
            }
        }

        public void readData(AmebaStream In)
        {
            _shopCode = In.readUTF();
            _type = In.readByte();
        }

        public void writeData(AmebaStream Out)
        {
          
            Out.writeUTF(_shopCode);
            Out.writeByte(this._type);
        }

        public sbyte _type { get; set; }
    }
}

