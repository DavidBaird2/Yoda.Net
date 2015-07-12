using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Yoda.Net.Networking.Packet.Info.area
{
    public class ListBundleTravelAreaData : ICommandData
    {
       public string categoryCode;
       public string code;

        public int packetId
        {
            get
            {
                return PacketId.TRAVEL_AREA;
            }
        }

        public void readData(PiggStream In)
        {
            categoryCode = In.readUTF();
            code = In.readUTF();
        }


        public void writeData(PiggStream stream)
        {
            stream.writeUTF(this.categoryCode);
            stream.writeUTF(this.code);
            return;
        }
    }
}

