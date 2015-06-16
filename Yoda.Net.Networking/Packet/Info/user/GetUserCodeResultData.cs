namespace libPigg.net.info.user
{

    using System;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Info;

    public class GetUserCodeResultData : IPacket
    {
        public string hexCode;
        public string method;


        public int packetId
        {
            get
            {
                return PacketId.GET_USER_CODE_RESULT;
            }
        }

        public void readData(AmebaStream In)
        {
            this.hexCode = In.readUTF();
            this.method = In.readUTF();
        }

        public void writeData(AmebaStream Out)
        {

        }
    }
}

