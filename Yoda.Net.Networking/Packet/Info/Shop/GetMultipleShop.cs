
namespace Yoda.Net.Networking.Packet.Info.Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Yoda.Net.Networking.Data.LogicShop;



    public class GetMultipleShopResultData : ICommandData
    {
        public GetMultipleShopResultData()
        {
        }
  
        public int packetId
        {
            get
            {
                return PacketId.GET_MULTIPLE_SHOP_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            this.data = new LogicShopInfo();
            this.data.readData(In);
    
        }

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
        }

   
        internal LogicShopInfo data { get; set; }
    }
}

