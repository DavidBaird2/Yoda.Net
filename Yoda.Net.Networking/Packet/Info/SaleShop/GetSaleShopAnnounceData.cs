
namespace Yoda.Net.Networking.Packet.Info.SaleShop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;



    public class GetSaleShopAnnounceData : ICommandData
    {


        public int packetId
        {
            get
            {
                return PacketId.GET_SALE_ANNOUNCE;
            }
        }
     
        public void readData(PiggStream In)
        {

        }

        public void writeData(PiggStream Out)
        {
        
        }
    }
}

