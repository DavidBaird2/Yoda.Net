namespace Yoda.Net.Networking.Packet.Info.Cosme
{
    
    
    using System;
    using System.Collections;

    public class GetShopCosmeticDetailData : ICommandData,IEncrypted
    {
        public GetShopCosmeticDetailData()
        {
        }
   
        public int packetId
        {
            get
            {
                return PacketId.GET_SHOP_COSME_DETAIL;
            }
        }
      
        public void readData(PiggStream In)
        {
            shopCode = In.readUTF();
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(shopCode);
            return;
        }

        public string shopCode { get; set; }
    }
}

