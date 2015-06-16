namespace Yoda.Net.Networking.Packet.Info.shop
{
    
    
    using System;
    public class TreasureGetData : IPacket
    {
        private int _treasureId;
        private string _code;
        public TreasureGetData(int treasureId, string code)
        {
            _treasureId = treasureId;
            _code = code;
            return;
        }

        public int packetId
        {
            get
            {
                return PacketId.TREASURE_GET;
            }
        }

        public void readData(AmebaStream In)
        {
          /*  this.shopCode = In.readUTF();
            this.itemType = In.readUTF();
            this.itemCode = In.readUTF();
            this.coupon = In.readBoolean();
            this.shopType = In.readInt();
            this.quantity = In.readInt();*/
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeInt(_treasureId);
            Out.writeUTF(_code);
            return;
        }
    }
}

