
namespace Yoda.Net.Networking.Packet.Info.Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Yoda.Net.Networking.Data.Common;



    public class GetPiggShopRanking : ICommandData,IEncrypted, IncludeClientTime
    {
        public GetPiggShopRanking()
        {
        }


        public int packetId
        {
            get
            {
                return PacketId.GET_PIGG_SHOP_ITEM_RANKING;
            }
        }
      
        public void readData(PiggStream In)
        {
            type = In.readUTF();
            category = In.readUTF();
            termType = In.readByte();
            originId = In.readInt();
        }            

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(this.type);
            Out.writeUTF(this.category);
            Out.writeByte(this.termType);
            Out.writeInt(this.originId);
        }



        public string type { get; set; }

        public string category { get; set; }

        public sbyte termType { get; set; }

        public int originId { get; set; }
    }
}

