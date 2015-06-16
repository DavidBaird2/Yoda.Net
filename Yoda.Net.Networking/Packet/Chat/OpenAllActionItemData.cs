namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    

    public class OpenAllActionItemData : IPacket
    {
        public int type;
        public string code;

        public OpenAllActionItemData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.OPEN_ALL_ACTION_ITEM;
            }
        }

        public void readData(AmebaStream In)
        {
          
        }

        public void writeData(AmebaStream Out)
        {
        }
    }
}

