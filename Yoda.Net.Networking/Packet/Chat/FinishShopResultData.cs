namespace Yoda.Net.Networking.Packet.Chat
{
    using Yoda.Net.Networking;
    using System;
    using Yoda.Net.Networking.Packet;

	public class FinishShopResultData :ICommandData
	{
        public string userCode;
        public FinishShopResultData()
        {
            return;
        }
        public FinishShopResultData(string hexCode)
        {
            this.userCode = hexCode;
            return;
        }
        public int packetId
        {
            get
            {
                return PacketId.FINISH_SHOP_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            userCode = In.readUTF();
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(userCode);
            return;
        }

	}
}
