
namespace Yoda.Net.Networking.Packet.Info.area
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;



    public class GetShopData : IPacket, IEncrypted
    {
        public string shopCode;
        public string giftAcceptUser = "8874e43a01f8105e";
        public bool isAdminRequest;

        public int packetId
        {
            get
            {
                return PacketId.GET_SHOP;
            }
        }
        public GetShopData(string param1 = null, string param2 = null, bool param3 = false)
        {
            this.shopCode = param1;
            this.giftAcceptUser = param2;
            this.isAdminRequest = param3;
            return;
        } 
        public void readData(AmebaStream In)
        {
            shopCode = In.readUTF();
            giftAcceptUser = In.readUTF();
            isAdminRequest = In.readBoolean();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(shopCode);
            Out.writeUTF("8874e43a01f8105e");
            Out.writeBoolean(false);
        }
    }
}

