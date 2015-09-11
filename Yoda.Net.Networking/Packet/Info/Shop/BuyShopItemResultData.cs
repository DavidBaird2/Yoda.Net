
namespace Yoda.Net.Networking.Packet.Info.Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;



    public class BuyShopItemResultData : ICommandData
    {
        public string itemCode;
        public bool success;
        public string errorCode;
        public bool coupon;
        public int point;
        public string type;
        public int shopType;
        public bool soldOut;

        public int packetId
        {
            get
            {
                return PacketId.BUY_SHOP_ITEM_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            this.itemCode = In.readUTF();
            this.type = In.readUTF();
            this.coupon = In.readBoolean();
            this.point = In.readInt();
            this.success = In.readBoolean();
            this.shopType = In.readInt();
            this.soldOut = In.readBoolean();
            if (!this.success)
            {
                this.errorCode = In.readUTF();
            }
            return;
        }

        public void writeData(PiggStream Out)
        {

            throw new NotImplementedException();
        }
    }
}

