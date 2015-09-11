namespace Yoda.Net.Networking.Packet.Info.BeginnerShop
{
    
    
    using System;


    public class GetBeginnerShopData : ICommandData, IEncrypted
    {
        public string shopCode;

        public GetBeginnerShopData()
        {

        }
        public GetBeginnerShopData(string shopCode)
        {
            this.shopCode = shopCode;
        }

        public int packetId
        {
            get
            {
                return PacketId.GET_BEGINNER_SHOP;
            }
        }

        public void readData(PiggStream In)
        {
            shopCode = In.readUTF();
            type = In.readByte();
        }

        public void writeData(PiggStream Out)
        {
          
            Out.writeUTF(shopCode);
            Out.writeByte(this.type);
        }

        public sbyte type { get; set; }
    }
}

