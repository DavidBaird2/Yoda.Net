using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Yoda.Net.Networking.Packet.Chat
{
	public class DoActionResultData :ICommandData 
	{
               public string userCode;
               public string actionCode;
        public DoActionResultData(string _code)
        {
            this.actionCode = _code;
            return;
        }
        public DoActionResultData()
        {
            return;
        }

        public int packetId
        {
            get
            {
                return PacketId.ACTION_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            this.userCode = In.readUTF();
            this.actionCode = In.readUTF();
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(userCode);
            Out.writeUTF(actionCode);
        }

	}
}
