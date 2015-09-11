using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Channel.TimeTable
{
    public class TimetableVjData
    {
        		//variables/etc.
		public string userCode;                                    
		public string nickname;                                    
		public bool isPlaying;                                  

		public void readData(PiggStream stream)
		{	
			this.userCode = stream.readUTF();
			this.nickname = stream.readUTF();
			this.isPlaying = stream.readBoolean();
		}
        public void writeData(PiggStream stream)
        {
            stream.writeUTF(userCode);
            stream.writeUTF(nickname);
            stream.writeBoolean(isPlaying);
        }
    }
}
