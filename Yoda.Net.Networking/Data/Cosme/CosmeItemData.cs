using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Cosme
{
    public class CosmeItemData
    {
        public void readData(PiggStream In)
        {
            this.itemCode = In.readUTF();
            this.type = In.readUTF();
            this.title = In.readUTF();
            this.descrpition = In.readUTF();
            this.quantity = In.readInt();
            this.limitTime = In.readInt();
            this.isUsed = In.readBoolean();



            this.expired = In.readTime();


            this.newParts = In.readBoolean();
        }

        public string itemCode { get; set; }

        public string type { get; set; }

        public string title { get; set; }

        public string descrpition { get; set; }

        public int quantity { get; set; }

        public int limitTime { get; set; }

        public bool isUsed { get; set; }

        public bool newParts { get; set; }

        public DateTime expired { get; set; }

        public DateTime serverTime { get; set; }
    }
}
