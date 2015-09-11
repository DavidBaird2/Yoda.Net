namespace Yoda.Net.Networking.Packet.Info.User
{

    using System;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Info;

    public class StartCreateUserResultData : ICommandData
    {
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
            this.realzone = In.readByte();
            this.nickname = In.readUTF();
            this.inviterUserCode = In.readUTF();
            this.inviterNickName = In.readUTF();
            this.tutorialType = In.readUTF();

        }

        public void writeData(PiggStream Out)
        {
            Out.writeByte(realzone);
            Out.writeUTF(nickname);
            Out.writeUTF(inviterUserCode);
            Out.writeUTF(inviterNickName);
            Out.writeUTF(tutorialType);
        }

        public sbyte realzone { get; set; }

        public string inviterUserCode { get; set; }

        public string inviterNickName { get; set; }

        public string tutorialType { get; set; }
    }
}

