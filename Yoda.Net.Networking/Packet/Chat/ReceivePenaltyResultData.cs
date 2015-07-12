using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using Yoda.Net.Networking.Packet.Chat;
namespace Yoda.Net.Networking.Packet.Chat
{
	public class ReceivePenaltyResultData :ICommandData 
	{
        public ReceivePenaltyResultData()
        {
        }
        public int ReceivePenaltyResutData;
        public ReceivePenaltyResultData(int _code)
        {
            this.ReceivePenaltyResutData = _code;
            return;
        }

        public int packetId
        {
            get
            {
                return PacketId.RECEIVE_PENALTY_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            ReceivePenaltyResutData = In.readInt();
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(ReceivePenaltyResutData);
            return;
        }

	}
}
