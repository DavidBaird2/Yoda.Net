
namespace Yoda.Net.Networking.Packet.Info.Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Yoda.Net.Networking.Data.Common;

    public class BuyGiftItemData : ICommandData, IEncrypted
    {
        public ShopGiftBuyData _data;
        public string userCode;
        public string giftShopCode;
        public string giftItemCode;
        public string giftItemType;
        public int giftQuantity;
        public string wrappingShopCode;
        public string wrappingItemCode;
        public string wrappingItemType;
        public string giftMessage;
        public Double giftReserveDate = -1;

        public int packetId
        {
            get
            {
                return PacketId.BUY_GIFT_ITEM;
            }
        }

        public void readData(PiggStream In)
        {

            this.userCode = In.readUTF();
            this.giftShopCode = In.readUTF();
            this.giftItemCode = In.readUTF();
           this.giftItemType= In.readUTF();
           this.giftQuantity= In.readInt();
      this.wrappingShopCode= In.readUTF();
            this.wrappingItemCode= In.readUTF();
            this.wrappingItemType= In.readUTF();
           this.giftMessage= In.readUTF();
      this.giftReserveDate=In.readDouble();
        }

        public void writeData(PiggStream Out)
        {

            Out.writeUTF(this.userCode);
            Out.writeUTF(this.giftShopCode);
            Out.writeUTF(this.giftItemCode);
            Out.writeUTF(this.giftItemType);
            Out.writeInt(this.giftQuantity);
            Out.writeUTF(this.wrappingShopCode);
            Out.writeUTF(this.wrappingItemCode);
            Out.writeUTF(this.wrappingItemType);
            Out.writeUTF(this.giftMessage);
            Out.writeDouble(this.giftReserveDate);
        }
    }
}

