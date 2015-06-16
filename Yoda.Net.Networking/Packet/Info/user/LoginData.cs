namespace libPigg.net.info.user
{

    using System;
    using System.Runtime.InteropServices;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;


    public class LoginData : IPacket, IEncrypted
    {
        public string _amebaId;
        public string _password;
        public string _ticket;
        public bool _fromAndroid;
        public string _agent;
        public string _flashPlayerVersion;
        public string _amebaAuthTicket;
        public string _frmid;
        public LoginData()
        {
        }

        public LoginData(string ticket,string amebaAuthTicket, string agent = "", string flashPlayerVersion = "",string frmid="")
        {
            this._ticket = ticket;
            this._amebaId = "";
            this._frmid = frmid;
            this._password = "";
            this._fromAndroid = false;
            this._agent = agent;
            this._flashPlayerVersion = flashPlayerVersion;
            _amebaAuthTicket = amebaAuthTicket;
        }

        public void amebaId(string param1)
        {
            this._amebaId = param1;
        }

        public int packetId
        {
            get
            {
                return 0x100;
            }
        }

        public void readData(AmebaStream In)
        {
            this._ticket = In.readUTF();
            this._amebaId = In.readUTF();
            this._password = In.readUTF();
            this._fromAndroid = In.readBoolean();
            this._agent = In.readUTF();
            this._flashPlayerVersion = In.readUTF();
            this._amebaAuthTicket = In.readUTF();
            this._frmid = In.readUTF();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(this._ticket);
            Out.writeUTF(this._amebaId);
            Out.writeUTF(this._password);
            Out.writeBoolean(this._fromAndroid);
            Out.writeUTF(_agent);
            Out.writeUTF(_flashPlayerVersion);
            Out.writeUTF(_amebaAuthTicket);
            Out.writeUTF(_frmid);
        }
    }
}

