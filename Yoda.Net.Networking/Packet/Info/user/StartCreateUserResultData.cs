namespace libPigg.net.info.user
{

    using System;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Info;

    public class StartCreateUserResultData : IPacket
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

        public void readData(AmebaStream In)
        {
            zone = In.readByte();
            nickname = In.readUTF();
        }

        public void writeData(AmebaStream Out)
        {

        }
    }
}

