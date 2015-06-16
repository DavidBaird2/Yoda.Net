namespace Yoda.Net.Networking.Data.Room
{
    
    using Yoda.Net.Data.Common;
    using System;

    public class DefineAvatar : DefineData
    {
        public AvatarData data;
        public PartData part;
        public bool friend;
        public void readData(AmebaStream In)
        {
            this.data = new AvatarData();
            this.data.readData(In);
        }
    }
}

