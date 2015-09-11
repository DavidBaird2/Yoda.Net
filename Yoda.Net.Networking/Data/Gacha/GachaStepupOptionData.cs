using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoda.Net.Networking.Data.Gacha
{
    public class GachaStepupOptionData
    {
        public string bonusType;
        public int quantity;

        public GachaStepupOptionData(string bonusType, int quantity)
        {
            // TODO: Complete member initialization
            this.bonusType = bonusType;
            this.quantity = quantity;
        }
    }
}
