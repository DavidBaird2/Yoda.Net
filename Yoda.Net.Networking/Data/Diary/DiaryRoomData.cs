
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Diary
{
    public class DiaryRoomData
    {
           
      public  DiaryRoomData() {

      }
      
      public bool isDiaryIconShow;
      
      public bool isDiaryReadEnable;
      
      public bool isDiaryNewPage;
      
      public int totalDiaryPage;

      public void readData(AmebaStream param1)
      {
         this.isDiaryIconShow = param1.readBoolean();
         this.isDiaryReadEnable = param1.readBoolean();
         this.isDiaryNewPage = param1.readBoolean();
         this.totalDiaryPage = param1.readInt();
      }
    }
}
