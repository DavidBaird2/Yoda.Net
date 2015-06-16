namespace libPigg.net.info.user
{

    using System;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Info;

    public class GetUserCodeData : IPacket, IEncrypted
    {
        public string _amebaId;
          public string _method;

          public GetUserCodeData(string amebaId, string method)
        {
            this._amebaId = amebaId;
            this._method = method;
        }
        public int packetId
        {
            get
            {
                return PacketId.GET_USER_CODE;
            }
        }

        public void readData(AmebaStream In)
        {

        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(this._amebaId);
            Out.writeUTF(this._method);
        }
    }
}

