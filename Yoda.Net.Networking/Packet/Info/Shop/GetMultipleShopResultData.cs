
namespace Yoda.Net.Networking.Packet.Info.Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;



    public class GetMultipleShop : ICommandData, IEncrypted
    {
        public GetMultipleShop()
        {
        }
  
        public int packetId
        {
            get
            {
                return PacketId.GET_MULTIPLE_SHOP;
            }
        }

        public void readData(PiggStream In)
        {
            shopCode = In.readUTF();
    
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(this.shopCode);
        }

        public string shopCode { get; set; }
    }
}

