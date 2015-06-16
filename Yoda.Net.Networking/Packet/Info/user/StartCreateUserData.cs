namespace libPigg.net.info.user
{

    using System;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Info;

    public class StartCreateUserData : IPacket
    {
        public string _ticket;
        public string _inviteCode ="";
        public StartCreateUserData(string ticket)
        {
            this._ticket = ticket;
        }
        public int packetId
        {
            get
            {
                return PacketId.START_CREATE_USER;
            }
        }

        public void readData(AmebaStream In)
        {
           _ticket= In.readUTF();
           _inviteCode = In.readUTF();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(_ticket);
            Out.writeUTF(_inviteCode);
        }
    }
}

