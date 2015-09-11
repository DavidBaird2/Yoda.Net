namespace Yoda.Net.Networking.Packet.Info.User
{

    using System;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Info;

    public class GetUserProfileData : ICommandData
    {
        public string code;

        public int packetId
        {
            get
            {
                return PacketId.GET_USER_PROFILE;
            }
        }

        public void readData(PiggStream In)
        {
            code = In.readUTF();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(code);
        }
    }
}

