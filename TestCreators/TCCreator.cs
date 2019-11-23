using TestCreators.Workers;
using System.Collections.Generic;

namespace TestCreators
{
    public class TCCreator
    {

        public static BonusCampaign TestEngineBonusCampaign(IDictionary<string, string> stepParameters)
        {
            var bcp = new BonusCampaignParameters(stepParameters);

            return new BonusCampaign(bcp);
        }

        #region
        public static BonusCampaign TestEngineBonusCampaign()
        {
            var bcp = new BonusCampaignParameters("-1", "StepBonusName");

            return new BonusCampaign(bcp);
        }

        public static BonusCampaignParameters bcp => new BonusCampaignParameters("-1", "StepBonusName");
        public static BonusCampaign TestEngineBonusCampaignE() => new BonusCampaign(bcp);

        public static BonusCampaign TestEngineBonusCampaign_fail()
        {
            var bcp = new BonusCampaignParameters();

            return new BonusCampaign(bcp);
        }
        #endregion
    }
}
