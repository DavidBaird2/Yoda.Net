namespace Yoda.Net.Networking.Packet.Info.User
{

    using System;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Info;

    public class StartCreateUserResultData : ICommandData
    {
        public int zone;
        public string nickname;
        public StartCreateUserResultData()
        {

        }
        public int packetId
        {
            get
            {
                return PacketId.START_CREATE_USER_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            zone = In.readByte();
            nickname = In.readUTF();
        }

        public void writeData(PiggStream Out)
        {

        }
    }
}

