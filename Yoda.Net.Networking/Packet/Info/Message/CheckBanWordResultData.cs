using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Yoda.Net.Networking.Packet.Info.Message
{
    public class CheckBanWordResultData : ICommandData
    {
        public string msg;
        public bool isBan;

        public CheckBanWordResultData()
        {
            return;
        }

        public int packetId
        {
            get
            {
                return PacketId.CHECK_BAN_WORD_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            isBan = In.readBoolean();
            msg = In.readUTF();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeBoolean(isBan);
            Out.writeUTF(msg);
        }
    }
}
