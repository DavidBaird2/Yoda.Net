
namespace Yoda.Net.Networking.Packet.Info.Gold
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;



    public class CheckGoldData  : ICommandData
    {
        public CheckGoldData()
        {
        }
 

        public int packetId
        {
            get
            {
                return PacketId.CHECK_AMEGOLD_EXCHANGEABLE_FOR_AS_COIN;
            }
        }
       
        public void readData(PiggStream In)
        {
 
        }

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
        }
    }
}

