
namespace Yoda.Net.Networking.Packet.Info.Gold
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;



    public class CheckGoldResultData : ICommandData
    {
        public CheckGoldResultData()
        {
        }
		public bool exchanged;                                  
		public int gold;                                           
		public int asCoin;                                         
		public int total;        

        public int packetId
        {
            get
            {
                return PacketId.CHECK_AMEGOLD_EXCHANGEABLE_FOR_AS_COIN_RESULT;
            }
        }
       
        public void readData(PiggStream In)
        {
            this.exchanged = In.readBoolean();

            if (!this.exchanged)
            {
                this.gold = In.readInt();
                this.asCoin = In.readInt();
                this.total = (this.gold + this.asCoin);
            }
        }

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
        }
    }
}

