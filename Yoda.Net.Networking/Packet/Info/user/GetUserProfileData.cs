namespace libPigg.net.info.user
{

    using System;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Info;

    public class GetUserProfileData : IPacket
    {
        public string code;

        public int packetId
        {
            get
            {
                return PacketId.GET_USER_PROFILE;
            }
        }

        public void readData(AmebaStream In)
        {
            code = In.readUTF();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(code);
        }
    }
}

