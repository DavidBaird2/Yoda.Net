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

        public void readData(PiggStream stream)
        {
            this.code = stream.readUTF();
            this.type = stream.readUTF();
            this.name = stream.readUTF();
            this.description = stream.readUTF();
            this.time = stream.readInt();
            this.quantity = stream.readInt();
            this.placed = stream.readBoolean();
        }
    }
}

