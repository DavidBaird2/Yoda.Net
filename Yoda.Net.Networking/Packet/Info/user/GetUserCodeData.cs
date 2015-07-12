namespace Yoda.Net.Networking.Packet.Info.User
{

    using System;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Info;

    public class GetUserCodeData : ICommandData, IEncrypted
    {
        public GetUserCodeData()
        {
        }
        public string amebaId;
          public string method;

          public GetUserCodeData(string amebaId, string method)
        {
            this.amebaId = amebaId;
            this.method = method;
        }
        public int packetId
        {
            get
            {
                return PacketId.GET_USER_CODE;
            }
        }

        public void readData(PiggStream In)
        {
            throw new NotImplementedException();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(this.amebaId);
            Out.writeUTF(this.method);
        }
    }
}

