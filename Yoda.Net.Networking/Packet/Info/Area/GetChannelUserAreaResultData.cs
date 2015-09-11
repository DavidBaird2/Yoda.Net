using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Yoda.Net.Networking.Packet.Info.Area
{
    public class GetChannelUserAreaResultData : ICommandData
    {

        public string categoryCode;
        public string areaCode;


        public int packetId
        {
            get
            {
                return PacketId.VJ_CHANNEL_USER_AREA_RESULT;
            }
        }

        public void readData(PiggStream In)
        {

            this.categoryCode = In.readUTF();
            this.areaCode = In.readUTF();

            return;

        }

        public void writeData(PiggStream Out)
        {


            return;
        }
    }
}
