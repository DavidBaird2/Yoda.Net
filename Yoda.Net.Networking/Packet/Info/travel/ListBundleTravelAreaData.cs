using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Yoda.Net.Networking.Packet.Info.area
{
    public class ListBundleTravelAreaData : IPacket
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

        public void readData(AmebaStream In)
        {
            categoryCode = In.readUTF();
            code = In.readUTF();
        }


        public void writeData(AmebaStream param1)
        {
            param1.writeUTF(this.categoryCode);
            param1.writeUTF(this.code);
            return;
        }
    }
}

