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

    }
}
