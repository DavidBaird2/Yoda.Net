namespace Yoda.Net.Networking.Packet.Info.User
{

    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Data.Common;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Info;
    public class GetUserBodyResultData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.GET_USER_BODY_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            this.part = new BodyPartData();
            this.color = new BodyColorData();
            this.pos = new BodyPositionData();
            this.part.gender = In.readByte();

            var hug2 = In.readUTF();

            this.part.readData(In);
            this.color.readData(In);
            this.pos.readData(In);
        }

        public void writeData(PiggStream Out)
        {

        }

        public BodyPartData part { get; set; }

        public BodyColorData color { get; set; }

        public BodyPositionData pos { get; set; }
    }
}

