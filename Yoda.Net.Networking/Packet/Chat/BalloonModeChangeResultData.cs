using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Yoda.Net.Networking.Packet.Chat
{
	public class BalloonModeChangeResultData :ICommandData
	{
        public BalloonModeChangeResultData()
        {
            return;
        }

        public int packetId
        {
            get
            {
                return PacketId.BALLOON_CHANGE_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            this.hexCode = In.readUTFBytes(16);
            this.mode = In.readByte();
        }

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
         
        }


        public string hexCode { get; set; }

        public sbyte mode { get; set; }
    }
}
