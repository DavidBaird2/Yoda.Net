using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Yoda.Net.Networking.Packet.Chat
{
	public class GoodPiggResultData :ICommandData
    {
        public string userCode { get; set; }

        public int receiveCount { get; set; }

        public string sendCode { get; set; }

        public int sendCount { get; set; }

        public GoodPiggResultData()
        {
         
            return;
        }
  
        public int packetId
        {
            get
            {
                return PacketId.GOOD_PIGG_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            this.userCode = In.readUTF();
            this.receiveCount = In.readInt();
            this.sendCode = In.readUTF();
            this.sendCount = In.readInt();
            return;
        }

        public void writeData(PiggStream Out)
        {
              Out.writeUTF(this.userCode);
             Out.writeInt( this.receiveCount);
              Out.writeUTF(this.sendCode );
             Out.writeInt( this.sendCount);
            return;
        }



    }
}
