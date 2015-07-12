
namespace Yoda.Net.Networking.Packet.Info.area
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;



    public class BuyShopItemData : ICommandData, IEncrypted
    {
   
        public string itemCode;
        public string itemType;
        public string shopCode;
        public bool coupon;
        public int quantity;
        public int shopType;


        public int packetId
        {
            get
            {
                return PacketId.BUY_SHOP_ITEM;
            }
        }

        public void readData(PiggStream In)
        {
            this.shopCode = In.readUTF();
            this.itemType = In.readUTF();
            this.itemCode = In.readUTF();
            this.coupon = In.readBoolean();
            this.shopType = In.readInt();
            this.quantity = In.readInt();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(this.shopCode);
            Out.writeUTF(this.itemType);
            Out.writeUTF(this.itemCode);
            Out.writeBoolean(this.coupon);
            Out.writeInt(this.shopType);
            Out.writeInt(this.quantity);
        }
    }
}

