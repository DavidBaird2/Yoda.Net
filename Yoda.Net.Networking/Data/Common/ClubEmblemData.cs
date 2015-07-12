namespace Yoda.Net.Networking.Data.Common
{
    using System;
    using System.Collections;
    using Yoda.Net.Networking;
    
    
    public class ClubEmblemData 
    {
        public int Base;
        public int simple;
        public bool isMember;
        public int updateTime;
        public int simpleColor;
        public int baseColor;
        public int symbol;

        public ClubEmblemData()
        {
            return;
        }

        public void readData(PiggStream In)
        {
            symbol = In.readInt();
            Base = In.readInt();
            simple = In.readInt();
            baseColor = In.readInt();
            simpleColor = In.readInt();
            updateTime = In.readInt();
            isMember = In.readBoolean();
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(symbol);
            Out.writeInt(Base);
            Out.writeInt(simple);
            Out.writeInt(baseColor);
            Out.writeInt(simpleColor);
            Out.writeInt(updateTime);
            Out.writeBoolean(isMember);
            return;
        }

        public void reset()
        {
            Base = 0;
            symbol = 0;
            simple = 0;
            baseColor = 0;
            simpleColor = 0;
            updateTime = 0;
            isMember = false;
            return;
        }

    }
}


