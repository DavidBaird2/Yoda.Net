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
        public CosmeDressUpItemData(String param1 = "", string param2 = "")
        {
            itemCode = param1;
            type = param2;
            return;
        }

        public void readData(AmebaStream In)
        {
            itemCode = In.readUTF();
            type = In.readUTF();
            newParts = In.readBoolean();
            return;
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(itemCode);
            Out.writeUTF(type);
            Out.writeBoolean(newParts);
            return;
        }
    }
}
