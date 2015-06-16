namespace Yoda.Net.Data.Common
{

    
    using Yoda.Net.Networking.Data.Club;
    using System;
    using Yoda.Net.Networking;
    

    public class ClubConfigData
    {
        public string clubCode;
        public string title;
        public bool isPublic;
        public string description;

       public void readData(AmebaStream In)
        {
            title = In.readUTF();
            isPublic = In.readBoolean();
            description = In.readUTF();
            clubCode = In.readUTF();
            return;
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(title);
            Out.writeBoolean(isPublic);
            Out.writeUTF(description);
            Out.writeUTF(clubCode);
            return;
        }

        public void setData(ClubConfigData param1)
        {
            title = param1.title;
            isPublic = param1.isPublic;
            description = param1.description;
            clubCode = param1.clubCode;
            return;
        }

        public void reset()
        {
            title = "";
            isPublic = true;
            description = "";
            clubCode = "meeting";
            return;
        }

    }
}

