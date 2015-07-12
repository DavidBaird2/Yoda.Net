using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Yoda.Net.Networking.Packet.Chat
{
	public class DoActionData :ICommandData ,IEncrypted
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

        public void readData(PiggStream In)
        {
            code = In.readUTF();
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(code);
            return;
        }

	}
}
