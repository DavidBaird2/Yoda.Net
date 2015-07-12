using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoda.Net.Networking.Packet.Chat
{
	public class DoCrackActionData :ICommandData ,IEncrypted
	{
        public DoCrackActionData()
        {
        }
        public string code;
        public DoCrackActionData(string code)
        {
            this.code = code;
            return;
        }

        public int packetId
        {
            get
            {
                return PacketId.ACTION;
            }
        }

        public void readData(PiggStream In)
        {
            code = In.readUTF();
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeShort((short)(code.Length + 8));
            Out.writeUTFBytes(code);
            Out.writeBoolean(false);
            Out.writeUTFBytes("_secret");
            return;
        }

	}
}
