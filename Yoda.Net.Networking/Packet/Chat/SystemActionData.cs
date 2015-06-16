namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;
    

    public class SystemActionData : IPacket, IEncrypted
    {
        private string _code;
        public string code;

        public SystemActionData()
        {
        }

        public SystemActionData(string param1)
        {
            this._code = param1;
        }

        public int packetId
        {
            get
            {
                return 0x414;
            }
        }

        public void readData(AmebaStream In)
        {
            this.code = In.readUTF();
            
        }

        public void writeData(AmebaStream Out)
        {
        /*    Out.writeShort((byte)(this._code.Length+1));
            Out.writeUTFBytes(this._code);
            Out.writeBoolean(false);*/
                 Out.writeUTF(this._code);
        }
    }
}

