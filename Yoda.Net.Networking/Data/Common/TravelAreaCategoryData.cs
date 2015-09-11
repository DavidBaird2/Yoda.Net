using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoda.Net.Networking.Data.Common
{
    public class TravelAreaCategoryData
    {
        public string areaCode;
        public string areaName;
        public int areaType;
        public List<TravelAreaData> list;
        public sbyte condition;
        public bool isExeceptionArea;
        public void readData(PiggStream In)
        {
            this.areaCode = In.readUTF();
            this.areaName = In.readUTF();
            this.areaType = In.readInt();
            this.condition = In.readByte();
            this.isExeceptionArea = false;
        }

    }
}
