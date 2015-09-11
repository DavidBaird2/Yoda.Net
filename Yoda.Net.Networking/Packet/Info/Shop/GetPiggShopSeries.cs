
namespace Yoda.Net.Networking.Packet.Info.Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Yoda.Net.Networking.Data.Common;



    public class GetPiggShopSeries : ICommandData 
    {
        public GetPiggShopSeries()
        {
        }


        public int packetId
        {
            get
            {
                return PacketId.GET_PIGGSHOP_SERIES;
            }
        }
      
        public void readData(PiggStream In)
        {
            seriesCode = In.readUTF();
            seriesTypeCode = In.readUTF();
        }            

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(this.seriesCode);
            Out.writeUTF(this.seriesTypeCode);
        }





        public string seriesCode { get; set; }

        public string seriesTypeCode { get; set; }
    }
}

