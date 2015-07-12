using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Pet
{
    public class PetSolveFurniturePlaceData
    {
        public string furnitureId;

        public int roomIndex;

        public int countSelf;

        public int countOther;

        public int countMax;


        public bool isAme
        {
            get
            {
                return this.furnitureId.IndexOf("_ame") != -1;
            }
        }


    }
}
