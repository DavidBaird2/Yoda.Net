namespace Yoda.Net.Networking.Data.Common
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

       public void readData(PiggStream In)
        {
            title = In.readUTF();
            isPublic = In.readBoolean();
            description = In.readUTF();
            clubCode = In.readUTF();
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(title);
            Out.writeBoolean(isPublic);
            Out.writeUTF(description);
            Out.writeUTF(clubCode);
            return;
        }

        public void setData(ClubConfigData stream)
        {
            title = stream.title;
            isPublic = stream.isPublic;
            description = stream.description;
            clubCode = stream.clubCode;
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

