using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Yoda.Net.Networking.Packet.Info.Area
{
    public class AreaTopInfoData : ICommandData
    {
     
        public string code;
  
        public int packetId
        {
            get
            {
                return PacketId.LIST_AREA_TOP;
            }
        }

        public void readData(PiggStream In)
        {
         
         
           
            return;

        }

        public void writeData(PiggStream Out)
        {
           
       
            return;
        }
    }
}
