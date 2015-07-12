using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using Yoda.Net.Networking.Packet.Chat;
namespace Yoda.Net.Networking.Packet.Chat
{
	public class SendPenaltyResultData :ICommandData 
	{
        public SendPenaltyResultData()
        {
        }
        public string result;
        public SendPenaltyResultData(string _code)
        {
            this.result = _code;
            return;
        }

        public int packetId
        {
            get
            {
                return PacketId.SEND_PENALTY_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            result = In.readUTF();
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(result);
            return;
        }

	}
}
