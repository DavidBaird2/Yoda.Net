namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;
    
    using Yoda.Net.Networking.Packet.Data.gift;

    public class OpenActionItemResultData : IPacket
    {
        public int sequence;
        public GiftData giftData;
        public OpenActionItemResultData()
        {
        }



        public int packetId
        {
            get
            {
                return PacketId.OPEN_GIFT_ITEM_RESULT;
            }
        }

        public void readData(AmebaStream In)
        {

            sequence = In.readInt();
            giftData = new GiftData();
            giftData.giftCode = In.readInt();
            giftData.userCode = In.readUTF();
            giftData.userName = In.readUTF();
            giftData.itemCode = In.readUTF();
            giftData.itemType = In.readUTF();
            giftData.itemQuantity = In.readInt();
            giftData.itemName = In.readUTF();
            giftData.message = In.readUTF();
            giftData.actionItemType = In.readByte();
        }

        public void writeData(AmebaStream Out)
        {
   
        }
    }
}

