namespace Yoda.Net.Networking.Packet.Info.User
{

    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Info;
    public class GetUserBodyData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.GET_USER_BODY;
            }
        }

        public void readData(PiggStream In)
        {

        }

        public void writeData(PiggStream Out)
        {

        }
    }
}

