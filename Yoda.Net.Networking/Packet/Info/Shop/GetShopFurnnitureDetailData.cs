
namespace Yoda.Net.Networking.Packet.Info.Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Yoda.Net.Networking.Data.LogicShop;



    public class GetShopFurnnitureDetailData : ICommandData,IEncrypted
    {
        public GetShopFurnnitureDetailData()
        {
        }
  
        public int packetId
        {
            get
            {
                return PacketId.GET_SHOP_FURNITURE_DETAIL;
            }
        }

        public void readData(PiggStream In)
        {
            In.writeUTF(shopCode);
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(shopCode);
        }



        public string shopCode { get; set; }
    }
}

