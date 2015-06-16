using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Yoda.Net.Networking.Packet.Info.area
{
    class GetUserAreaData : IPacket,IEncrypted
    {
     
        public string code;
  
        public int packetId
        {
            get
            {
                return PacketId.GET_USER_AREA;
            }
        }

        public void readData(AmebaStream In)
        {
         
            code = In.readUTF();
           
            return;

        }

        public void writeData(AmebaStream Out)
        {
           
            Out.writeUTF(code);
          
            return;
        }
    }
}
