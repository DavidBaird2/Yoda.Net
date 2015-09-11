namespace Yoda.Net.Networking.Data.Common
{

    using System;
    using Yoda.Net.Networking;

    public class UserItemData
    {
        public string category;
        public string description;
        public int id;
        public string itemId;
        public string name;
        public int order;
        public DateTime time;
        public bool used;
        public bool isCoordinateUsed;
        public bool isMannequinUsed;
        public byte rentalType;
        public DateTime rentalExpired;
        public int rentalAvailableTime;
        public void readData(PiggStream In)
        {
            this.id = In.readInt();
            this.order = In.readByte();
            this.used = this.order > 0;
            this.isCoordinateUsed = In.readBoolean();
            this.isMannequinUsed = In.readBoolean();
            this.category = In.readUTF();
            this.itemId = In.readUTF();
            this.name = In.readUTF();
            this.description = In.readUTF();
            this.time = In.readTime();
            this.rentalType = (byte)In.readByte();
            if (rentalType == 1) //TODO
            {
                this.rentalAvailableTime = In.readInt();
                this.rentalExpired = In.readTime();
            }
        }
    }
}

