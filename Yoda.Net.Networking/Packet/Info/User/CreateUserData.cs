namespace Yoda.Net.Networking.Packet.Info.User
{

    using System;
    using System.Drawing;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Info;
    using Yoda.Net.Networking.Packet.Info.Create;
    public class CreateUserData : ICommandData
    {
        public CreateAvatarData data;

        public byte[] image;
        public string nickname;
        public CreateUserData()
        {
            data = new CreateAvatarData();
            return;
        }
        public CreateUserData(CreateAvatarData cud, string nickname)
        {
            this.data = cud;
            this.nickname = nickname;
            return;
        }
        public int packetId
        {
            get
            {
                return PacketId.CREATE_USER;
            }
        }

        public void readData(PiggStream In)
        {
            short length = In.readShort();
            image = In.readBytes(length);
            nickname = In.readUTF();
            data.Decompress(In.readBytes((int)(In.length - In.position)));
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeShort(0);
            Out.writeUTF(nickname);
            Out.writeBytes(data.binary());
            return;
        }
    }
}

