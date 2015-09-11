using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoda.Net.Networking.Data.Gacha
{
    public class GachaStepupBonusAdditionalFeatureData
    {
        public int stepNum;
        public GachaStepupItemData gachaStepupItemData;
        public bool hasFeatureStep;

        public GachaStepupBonusAdditionalFeatureData(int stepNum, GachaStepupItemData gachaStepupItemData, bool hasFeatureStep)
        {
            // TODO: Complete member initialization
            this.stepNum = stepNum;
            this.gachaStepupItemData = gachaStepupItemData;
            this.hasFeatureStep = hasFeatureStep;
        }
    }
}
