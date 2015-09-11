
namespace Yoda.Net.Networking.Packet.Info.SaleShop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Yoda.Net.Networking.Data.Announce;



    public class GetSaleShopAnnounceResultData : ICommandData
    {


        public int packetId
        {
            get
            {
                return PacketId.GET_SALE_ANNOUNCE_RESULT;
            }
        }
     
        public void readData(PiggStream In)
        {
            this.exist = In.readBoolean();

            if (!this.exist) return;

            this.shopData = new AnnounceSaleShopData();
            this.shopData.readData(In);
        }

        public void writeData(PiggStream Out)
        {
        
        }

        public bool exist { get; set; }

        public AnnounceSaleShopData shopData { get; set; }
    }
}

