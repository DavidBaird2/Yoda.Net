using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Shop
{
    public class ShopCoinBannerLinkInfo
    {
        public void readData(PiggStream In)
		{	
			this.bannerImageURL = In.readUTF();
			this.bannerLinkURL = In.readUTF();
			this.text1Label = In.readUTF();
			this.text1IconType = In.readInt();
			this.text1LinkURL = In.readUTF();
			this.text2Label = In.readUTF();
			this.text2IconType = In.readInt();
			this.text2LinkURL = In.readUTF();
		}

        public string bannerImageURL { get; set; }

        public string bannerLinkURL { get; set; }

        public string text2LinkURL { get; set; }

        public int text2IconType { get; set; }

        public string text2Label { get; set; }

        public string text1LinkURL { get; set; }

        public string text1Label { get; set; }

        public int text1IconType { get; set; }
    }
}
