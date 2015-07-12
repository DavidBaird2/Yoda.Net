namespace Yoda.Net.Networking.Packet.Info.User
{

    using System;
    using System.Runtime.InteropServices;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;


    public class LoginData : ICommandData, IEncrypted
    {
        public string amebaId;
        public string password;
        public string ticket;
        public bool fromAndroid;
        public string agent;
        public string flashPlayerVersion;
        public string amebaAuthTicket;
        public string frmid;
        public LoginData()
        {
        }

        public LoginData(string ticket,string amebaAuthTicket, string agent = "", string flashPlayerVersion = "",string frmid="")
        {
            this.ticket = ticket;
            this.amebaId = "";
            this.frmid = frmid;
            this.password = "";
            this.fromAndroid = false;
            this.agent = agent;
            this.flashPlayerVersion = flashPlayerVersion;
            this.amebaAuthTicket = amebaAuthTicket;
        }

        public int packetId
        {
            get
            {
                return PacketId.LOGIN;
            }
        }

        public void readData(PiggStream In)
        {
            this.ticket = In.readUTF();
            this.amebaId = In.readUTF();
            this.password = In.readUTF();
            this.fromAndroid = In.readBoolean();
            this.agent = In.readUTF();
            this.flashPlayerVersion = In.readUTF();
            this.amebaAuthTicket = In.readUTF();
            this.frmid = In.readUTF();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(this.ticket);
            Out.writeUTF(this.amebaId);
            Out.writeUTF(this.password);
            Out.writeBoolean(this.fromAndroid);
            Out.writeUTF(agent);
            Out.writeUTF(flashPlayerVersion);
            Out.writeUTF(amebaAuthTicket);
            Out.writeUTF(frmid);
        }
    }
}

