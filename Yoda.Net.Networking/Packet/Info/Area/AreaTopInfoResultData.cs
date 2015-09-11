using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Yoda.Net.Networking.Packet.Info.Area
{
    public class AreaTopInfoResultData : ICommandData
    {
     
       
        public int packetId
        {
            get
            {
                return PacketId.LIST_AREA_TOP_RESULT;
            }
        }

        public void readData(PiggStream In)
        {


            this.title = In.readUTF();
            this.url = In.readUTF();
            return;

        }

        public void writeData(PiggStream Out)
        {

            Out.writeUTF(title);
            Out.writeUTF(url);
            return;
        }

        public string title { get; set; }

        public string url { get; set; }
    }
}
