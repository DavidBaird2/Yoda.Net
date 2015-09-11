namespace Yoda.Net.Networking.Packet.Info.User
{

    using System;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Info;

    public class StartCreateUserData : ICommandData
    {
        public StartCreateUserData()
        {
        }
        public string ticket;
        public string inviteCode = "";
        public StartCreateUserData(string ticket)
        {
            this.ticket = ticket;
        }
        public int packetId
        {
            get
            {
                return PacketId.START_CREATE_USER;
            }
        }

        public void readData(PiggStream In)
        {
            ticket = In.readUTF();
            inviteCode = In.readUTF();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(ticket);
            Out.writeUTF(inviteCode);
        }
    }
}

