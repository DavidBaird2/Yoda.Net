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
          public int type;
          public GetUserCodeData(string amebaId, string method,int type)
        {
            this.type = type;
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
            type = In.readByte();
            amebaId = In.readUTF();
            method = In.readUTF();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeByte((byte)type);
            Out.writeUTF(this.amebaId);
            Out.writeUTF(this.method);
        }
    }
}

