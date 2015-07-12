
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

      public void readData(PiggStream In)
      {
         this.isDiaryIconShow = In.readBoolean();
         this.isDiaryReadEnable = In.readBoolean();
         this.isDiaryNewPage = In.readBoolean();
         this.totalDiaryPage = In.readInt();
      }
        public void writeData(PiggStream Out)
      {
          Out.writeBoolean(this.isDiaryIconShow);
            Out.writeBoolean(this.isDiaryReadEnable);
           Out.writeBoolean( this.isDiaryNewPage);
          Out.writeInt(this.totalDiaryPage);
      }
    }
}
