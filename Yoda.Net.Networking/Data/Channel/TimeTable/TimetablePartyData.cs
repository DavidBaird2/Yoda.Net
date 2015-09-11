using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Networking.Data.Common;
using Yoda.Net.Networking.Data.Event;

namespace Yoda.Net.Networking.Data.Channel.TimeTable
{
    public class TimetablePartyData
    {
        
		public string title;                                       
		public string songName;                                    
		public string programkey;                                  
		public List<string> themes;                             
		public string userCode;                                    
		public string nickname;                                    
		public List<TimetableVjData> users;                     
		public string categoryCode;                                
		public string subCategoryCode;                             
		public List<string> comments;                           
		public int point;                                          
		public int totalUserCount;                                 
		public int totalCommentCount;                              
		public string areaCode;                                    
		public bool isEmpty;                                    
		public EventPickupData pickupData;                         


		public void readTravelData(PiggStream In)
		{	

			this.categoryCode = In.readUTF();
			this.subCategoryCode = In.readUTF();
			this.areaCode = In.readUTF();
			this.title = In.readUTF();
			this.songName = In.readUTF();
			this.programkey = In.readUTF();

			var count = In.readInt();

			this.themes = new List<string>(count);
            count.Times(() =>
            {
                this.themes.Add(In.readUTF());
               
            });

			this.userCode = In.readUTF();
			this.nickname = In.readUTF();
			count = In.readInt();
			this.users = new List<TimetableVjData>(count);
            count.Times(() =>
            {
                var timetableVjData = new TimetableVjData();
                timetableVjData.readData(In);

                this.users.Add(timetableVjData);
               
            });

			this.totalUserCount = In.readInt();
			this.pickupData = new EventPickupData();
			this.pickupData.readData(In);
		}


    }
}
