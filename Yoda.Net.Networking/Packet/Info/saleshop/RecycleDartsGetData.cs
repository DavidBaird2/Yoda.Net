
namespace Yoda.Net.Networking.Packet.Info.saleshop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    

    public class GetSalePoyonData : IPacket
    {


        public int packetId
        {
            get
            {
                return PacketId.GET_SALE_POYON;
            }
        }
     
        public void readData(AmebaStream In)
        {

        }

        public void writeData(AmebaStream Out)
        {
        
        }
    }
}

