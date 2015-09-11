using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Event
{
   public class EventPickupData
    {
        	
		public bool isPickup;                                   
		public int sortNum;                                        
		public bool isOfficial;                          

		public void readData(PiggStream stream)
		{
			if(this.isPickup = stream.readBoolean()){
				this.sortNum = stream.readInt();
				this.isOfficial = stream.readBoolean();
			}
		}
        public void writeData(PiggStream stream)
        {
            if (isPickup)
            {
                stream.writeInt(sortNum);
                stream.writeBoolean(isOfficial);
            }
        }

    }

}
