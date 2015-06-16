namespace libPigg.net.info.user
{

    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Info;
    public class CreateUserResultData : IPacket
    {

        public int packetId
        {
            get
            {
                return PacketId.CREATE_USER_RESULT;
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

