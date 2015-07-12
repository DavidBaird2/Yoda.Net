
namespace Yoda.Net.Networking.Packet.Info.area
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    

    public class BuyGiftItemResultData : ICommandData, IEncrypted
    {
         public string targetUser;
        public int shopKind;
        public string itemCode;
        public int point;
        public int spent;
        public bool success;
        public string errorCode;
        public bool soldOut;
        public string shopCode;

        public int packetId
        {
            get
            {
                return PacketId.BUY_GIFT_ITEM_RESULT;
            }
        }

        public void readData(PiggStream In)
        {

            this.success = In.readBoolean();
            if (this.success)
            {
                this.targetUser = In.readUTF();
                this.shopKind = In.readByte();
                this.itemCode = In.readUTF();
                this.point = In.readInt();
                this.spent = In.readInt();
                this.soldOut = In.readBoolean();
            }
            else
            {
                this.errorCode = In.readUTF();
                this.shopKind = In.readByte();
            }
            this.shopCode = In.readUTF();
            return;
        }

        public void writeData(PiggStream Out)
        {

            throw new NotImplementedException();
        }
    }
}

