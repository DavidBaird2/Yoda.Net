using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Yoda.Net.Networking.Packet.Chat
{
	public class BalloonModeChangeData :ICommandData
	{
        public BalloonModeChangeData()
        {
            return;
        }

        public int packetId
        {
            get
            {
                return PacketId.BALLOON_CHANGE;
            }
        }

        public void readData(PiggStream In)
        {
            this.mode = In.readByte();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeByte(mode);
         
        }



        public sbyte mode { get; set; }
    }
}
