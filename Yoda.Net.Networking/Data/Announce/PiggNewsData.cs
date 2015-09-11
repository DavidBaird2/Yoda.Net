
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Announce
{
    public class PiggNewsData
    {
        public string bannerThumbUrl;                              
		public string bannerJumpUrl;                              
		public bool isExternalLink;                              

		public void  readData(PiggStream In)
		{	
			this.bannerThumbUrl = In.readUTF();
			this.bannerJumpUrl = In.readUTF();
			this.isExternalLink = In.readBoolean();
		}
    }
}
