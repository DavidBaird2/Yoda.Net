using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoda.Net.Networking.Data.Event
{
    public class EventData
    {
       public bool roomEventCondition;                          
		public string areaCategory;                                 
		public string areaCode;                                     
		public string areaTitle;                                    
		public string category;                                     
		public string title;                                        
		public string description;                                  
		public DateTime createTime;                                   
		public bool image;                                       
		public string originPath;                                   
		public string thumbPath;                                    
		public int numPeople;                                       
		public int maxPeople;                                       
		public string ownerName;                                    
		public string ownerUserCode;                                
		public string dataType;                                     
		public bool warning;                                     
		public bool prohibition = false;                         
		public int publishing;                                      
		public bool likeEnabled;                                 
		public EventPickupData pickupData;                          
		public int roomIndex;                                       
        public void readTravelData(PiggStream In)
        {
            this.areaCategory = In.readUTF();
            this.areaCode = In.readUTF();
            this.areaTitle = In.readUTF();
            this.category = In.readUTF();
            this.title = In.readUTF();
            this.description = In.readUTF();
            this.numPeople = In.readInt();
            this.maxPeople = In.readInt();
            this.ownerUserCode = In.readUTF();
            this.ownerName = In.readUTF();
            this.originPath = In.readUTF();
            this.pickupData = new EventPickupData();
            this.pickupData.readData(In);
        }
    }
}
