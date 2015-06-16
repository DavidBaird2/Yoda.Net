using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Yoda.Net.Networking.Packet.Chat
{
	public class DoActionData :IPacket ,IEncrypted
	{
        public string code;
        public DoActionData(string _code)
        {
            this.code = _code;
            return;
        }
        public DoActionData()
        {
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
            Out.writeUTF(code);
            return;
        }

	}
}
