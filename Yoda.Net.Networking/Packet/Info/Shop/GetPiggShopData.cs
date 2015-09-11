
namespace Yoda.Net.Networking.Packet.Info.Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Yoda.Net.Networking.Data.Common;



    public class GetPiggShopData : ICommandData ,IEncrypted
    {
        public GetPiggShopData()
        {
        }


        public int packetId
        {
            get
            {
                return PacketId.GET_PIGGSHOP;
            }
        }
      
        public void readData(PiggStream In)
        {
            giftAcceptUser = In.readUTF();
            isAdminRequest = In.readBoolean();
        }            

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(this.giftAcceptUser);
            Out.writeBoolean(this.isAdminRequest);
        }





        public bool isAdminRequest { get; set; }

        public string giftAcceptUser { get; set; }
    }
}

