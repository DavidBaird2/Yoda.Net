
namespace Yoda.Net.Networking.Packet.Info.Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;



    public class GetPiggShopCategory : ICommandData
    {
        public GetPiggShopCategory()
        {
        }
   

        public int packetId
        {
            get
            {
                return PacketId.GET_PIGGSHOP_CATEGORY; 
            }
        }
       
        public void readData(PiggStream In)
        {
            type = In.readUTF();
            category = In.readUTF();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(this.type);
            Out.writeUTF(this.category);
        }

        public string type { get; set; }

        public string category { get; set; }
    }
}

