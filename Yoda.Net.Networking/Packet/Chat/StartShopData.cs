namespace Yoda.Net.Networking.Packet.Chat
{
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Chat;
    public class StartShopData : ICommandData
    {


        public StartShopData()
        {
        }


        public void readData(PiggStream In)
        {
        }

        public void writeData(PiggStream Out)
        {

        }

        public int packetId
        {
            get
            {
                return PacketId.START_SHOP;
            }
        }
    }
}

