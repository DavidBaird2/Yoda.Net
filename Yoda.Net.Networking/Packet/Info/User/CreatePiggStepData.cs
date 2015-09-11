namespace Yoda.Net.Networking.Packet.Info.User
{

    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Info;
    public class CreatePiggStepData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.CREATE_PIGG_STEP;
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

