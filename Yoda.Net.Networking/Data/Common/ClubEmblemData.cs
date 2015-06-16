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

        public void readData(AmebaStream In)
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

        public void writeData(AmebaStream Out)
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

        /* public function setData(param1:ClubEmblemData) : void
         {
             base = param1.base;
             symbol = param1.symbol;
             simple = param1.simple;
             baseColor = param1.baseColor;
             simpleColor = param1.simpleColor;
             updateTime = param1.updateTime;
             isMember = param1.isMember;
             return;
         }
     */
    }
}


