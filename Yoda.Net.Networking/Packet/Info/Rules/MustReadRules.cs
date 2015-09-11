
namespace Yoda.Net.Networking.Packet.Info.Rules
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;



    public class MustReadRules : ICommandData
    {


        public int packetId
        {
            get
            {
                return PacketId.MUST_READ_RULES;
            }
        }
     
        public void readData(PiggStream In)
        {

        }

        public void writeData(PiggStream Out)
        {
        
        }
    }
}

