using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoda.Net.Networking.Packet.Chat
{
	public class DoCrackActionData :IPacket ,IEncrypted
	{
        public string code;
        public DoCrackActionData(string _code)
        {
            this.code = _code;
            return;
        }

        public int packetId
        {
            get
            {
                return PacketId.ACTION;
            }
        }

        public void readData(AmebaStream In)
        {
            code = In.readUTF();
            return;
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeShort((short)(code.Length + 8));
            Out.writeUTFBytes(code);
            Out.writeBoolean(false);
            Out.writeUTFBytes("_secret");
            return;
        }

	}
}
