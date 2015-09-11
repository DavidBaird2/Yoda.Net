
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Networking.Data.Common;

namespace Yoda.Net.Networking.Data.Area
{
    public class HistoryAreaData
    {
        public string categoryCode;                                
		public string subCategoryCode;                             
		public string areaCode;                                    
		public string name;                                        
		public string description;                                 
		public int currentCount;                                   
		public int capacity;                                       
		public int zone;                                           
		public bool isFavorite;                                 
		public bool isSpeakArea;                                
		public TravelAreaData travelData;                          

		public void readData(PiggStream In)
		{	
			this.categoryCode = In.readUTF();
			this.subCategoryCode = In.readUTF();
			this.areaCode = In.readUTF();
			this.description = In.readUTF();
			this.name = In.readUTF();
			this.currentCount = In.readInt();
			this.capacity = In.readInt();
			this.zone = In.readByte();
			this.isSpeakArea = In.readBoolean();
			this.isFavorite = In.readBoolean();
		}
    }
}
