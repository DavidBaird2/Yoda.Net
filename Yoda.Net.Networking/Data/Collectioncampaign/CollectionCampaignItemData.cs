using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Collectioncampaign
{
    public class CollectionCampaignItemData
    {
        	public string itemName;                                     
		public string itemCode;                                    
		public string itemType;                                     
		public int itemRarity;                                    
		public int itemHolder;                                     
		public bool isSetItem;                                   
		public bool isCompleted;                               

		public void readData(PiggStream Im)
		{	
			this.itemCode = Im.readUTF();
			this.itemType = Im.readUTF();
			this.itemName = Im.readUTF();
			this.itemRarity = Im.readByte();
			this.itemHolder = Im.readInt();

			if(this.itemHolder > 0) this.isCompleted = true;
		}
    }
}
