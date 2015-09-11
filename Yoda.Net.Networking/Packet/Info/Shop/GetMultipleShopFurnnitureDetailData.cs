
namespace Yoda.Net.Networking.Packet.Info.Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Yoda.Net.Networking.Data.Common;



    public class GetMultipleShopFurnnitureDetailData : ICommandData ,IEncrypted
    {
        public GetMultipleShopFurnnitureDetailData()
        {
        }


        public int packetId
        {
            get
            {
                return PacketId.GET_MULTIPLE_SHOP_FURNITURE_DETAIL;
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

