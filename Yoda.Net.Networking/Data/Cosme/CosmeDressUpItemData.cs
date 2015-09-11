using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Yoda.Net.Networking.Data.Cosme
{
    public class CosmeDressUpItemData
    {
        public string itemCode;
        public string type;
        public Boolean  newParts;
        public CosmeDressUpItemData(String itemCode = "", string type = "")
        {
            this.itemCode = itemCode;
            this.type = type;
            return;
        }

        public void readData(PiggStream In)
        {
            itemCode = In.readUTF();
            type = In.readUTF();
            newParts = In.readBoolean();
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(itemCode);
            Out.writeUTF(type);
            Out.writeBoolean(newParts);
            return;
        }
    }
}
