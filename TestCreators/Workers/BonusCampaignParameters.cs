using System;
using System.Text;
using System.Collections.Generic;

namespace TestCreators.Workers
{
    public class BonusCampaignParameters
    {
        public long BonusId { get; set; }
        public string BonusName { get; set; }

        public BonusCampaignParameters()
        {
            CheckParsedParameters();
        }

        public BonusCampaignParameters(IDictionary<string, string> stepParameters)
        {
            ParseStepParameters(stepParameters);
            CheckParsedParameters();
        }


        public BonusCampaignParameters(string stepBonusId, string stepBonusName)
        {
            ParseStepParameters(stepBonusId, stepBonusName);
            CheckParsedParameters();
        }

        public void ParseStepParameters(IDictionary<string, string> d)
        {
            var stepBonusId = d["BCBonusID"];
            var stepBonusName = d["BCBonusName"];

            BonusId = long.Parse(stepBonusId);
            BonusName = stepBonusName;
        }

        public void ParseStepParameters(string stepBonusId, string stepBonusName)
        {
            BonusId = long.Parse(stepBonusId);
            BonusName = stepBonusName;
        }
        public void CheckParsedParameters()
        {
            var sb = new StringBuilder();
            if (BonusId == 0)
                sb.AppendLine(string.Format("Invalid bonus Id={0},", BonusId));
            if (BonusName == null)
                sb.AppendLine(string.Format("Invalid bonus name={0},", BonusName));

            if (sb.Length > 0)
                throw new Exception(sb.ToString());
        }
    }
}
