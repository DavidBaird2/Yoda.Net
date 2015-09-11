using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Yoda.Net.Networking.Packet.Info.Area
{
    public class GetUserAreaData : ICommandData,IEncrypted
    {
     
        public string code;
  
        public int packetId
        {
            get
            {
                return PacketId.GET_USER_AREA;
            }
        }

        public void readData(PiggStream In)
        {
         
            code = In.readUTF();
           
            return;

        }

        public void writeData(PiggStream Out)
        {
           
            Out.writeUTF(code);
          
            return;
        }
    }
}
