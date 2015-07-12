namespace Yoda.Net.Networking.Data.Room
{

    using System;
    using System.Drawing;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Info;
    using Yoda.Net.Networking.Packet.Info.create;
    public class CreateUserData : ICommandData
    {
        private CreateAvatarData data;

        private byte[] image;
        private string nickname;
        public CreateUserData()
        {
            data = new CreateAvatarData();
            return;
        }
        public CreateUserData(CreateAvatarData cud, string nickname  )
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

