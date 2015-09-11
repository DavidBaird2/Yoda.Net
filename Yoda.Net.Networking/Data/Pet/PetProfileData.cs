using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Pet
{
    public class PetProfileData
    {
        public string description { get; set; }

        public PetData petData { get; set; }

        public bool isTaken { get; set; }
    }
}
