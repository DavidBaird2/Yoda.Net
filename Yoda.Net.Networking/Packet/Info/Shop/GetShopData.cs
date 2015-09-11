
namespace Yoda.Net.Networking.Packet.Info.Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;



    public class GetShopData : ICommandData, IEncrypted
    {
        public GetShopData()
        {
        }
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
        public GetShopData(string shopCode = null, string giftAcceptUser = null, bool isAdminRequest = false)
        {
            this.shopCode = shopCode;
            this.giftAcceptUser = giftAcceptUser;
            this.isAdminRequest = isAdminRequest;
            return;
        } 
        public void readData(PiggStream In)
        {
            shopCode = In.readUTF();
            giftAcceptUser = In.readUTF();
            isAdminRequest = In.readBoolean();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(shopCode);
            Out.writeUTF(giftAcceptUser);
            Out.writeBoolean(false);
        }
    }
}

