namespace Yoda.Net.Networking.Data.Common
{
    
    using System;
    using Yoda.Net.Networking;

    public class UserActionItemData
    {
        public string type;
        public string code;
        public string name;
        public string description;
        public int time;
        public int quantity;
        public bool placed;

        public void readData(AmebaStream param1)
        {
            this.code = param1.readUTF();
            this.type = param1.readUTF();
            this.name = param1.readUTF();
            this.description = param1.readUTF();
            this.time = param1.readInt();
            this.quantity = param1.readInt();
            this.placed = param1.readBoolean();
        }
    }
}

