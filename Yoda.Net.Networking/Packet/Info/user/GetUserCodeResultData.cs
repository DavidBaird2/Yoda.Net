namespace Yoda.Net.Networking.Packet.Info.User
{

    using System;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Info;

    public class GetUserCodeResultData : ICommandData
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

        public void readData(PiggStream In)
        {
            this.hexCode = In.readUTF();
            this.method = In.readUTF();
        }

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
        }
    }
}

