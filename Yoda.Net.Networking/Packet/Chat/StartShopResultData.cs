namespace Yoda.Net.Networking.Packet.Chat
{
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Chat;

	public class StartShopResultData :ICommandData
	{
        public string hexCode;
        public StartShopResultData()
        {
            return;
        }
        public StartShopResultData(string hexCode)
        {
            this.hexCode = hexCode;
            return;
        }
        public int packetId
        {
            get
            {
                return PacketId.START_SHOP_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            hexCode = In.readUTFBytes(16);
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTFBytes(hexCode);
            return;
        }

	}
}
