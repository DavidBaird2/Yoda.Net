using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoda.Net.Networking.Data.Gacha
{
    public class GachaStepupBonusListData
    {
        public int originalPrice { get; set; }
        public void initialize(int count)
        {
            GachaStepupBonusOneStepListData oneStepListData = null;

            this.totalStep = count;
            this.list = new List<GachaStepupBonusOneStepListData>(count);

            var u = 0;

            while (u < count)
            {
                oneStepListData = new GachaStepupBonusOneStepListData();
                this.list.Add(oneStepListData);
                u++;
            }
        }


        public int totalStep { get; set; }

        public List<GachaStepupBonusOneStepListData> list { get; set; }
    }
}
