namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;
    

    public class SystemActionData2 : IPacket, IEncrypted
    {
        private string _code;
        public string code;

        public SystemActionData2()
        {
        }

        public SystemActionData2(string param1)
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
           Out.writeShort((byte)(this._code.Length+1));
            Out.writeUTFBytes(this._code);
            Out.writeBoolean(false);
        }
    }
}

