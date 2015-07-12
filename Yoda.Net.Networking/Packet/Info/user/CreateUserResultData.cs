namespace Yoda.Net.Networking.Packet.Info.User
{

    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Info;
    public class CreateUserResultData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.CREATE_USER_RESULT;
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

