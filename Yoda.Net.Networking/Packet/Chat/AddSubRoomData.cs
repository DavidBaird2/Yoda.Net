namespace Yoda.Net.Networking.Packet.Chat
{
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
 
	public class AddSubRoomData :ICommandData
	{
        public string buyType;
        public string authTicket;
        public AddSubRoomData(string buyType, string authTicket)
        {
            this.buyType = buyType;
            this.authTicket = authTicket;
            return;
        }
        public AddSubRoomData()
        {
            return;
        }

        public int packetId
        {
            get
            {
                return PacketId.ADD_SUB_ROOM;
            }
        }

        public void readData(PiggStream In)
        {
            buyType = In.readUTF();
            authTicket = In.readUTF();
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(buyType);
            Out.writeUTF(authTicket);
            return;
        }

	}
}
