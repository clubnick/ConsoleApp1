using System;
using System.Text;
using System.Collections.Generic;

namespace TestCreators.Workers
{
    public class BonusCampaignParameters
    {
        public long? BCBonusId { get; set; } // > 0 for modify bonus, -1 default for create new bonus
        public string BCBonusName { get; set; } // mandatory string

        public BonusCampaignParameters(IDictionary<string, string> stepParameters)
        {
            ParseStepParameters(stepParameters);
            CheckParsedParameters();
        }


        public void ParseStepParameters(IDictionary<string, string> d)
        {
            string pname = null;
            string s = null; ;
            try
            {

                pname = "BCBonusID";
                if (d.ContainsKey(pname) && !string.IsNullOrEmpty(s = d[pname])) BCBonusId = long.Parse(s.Trim());

                pname = "BCBonusName";
                if (d.ContainsKey(pname) && !string.IsNullOrEmpty(s = d[pname])) BCBonusName = s.Trim();
            }
            catch (Exception ex)
            {
                var emsg = "'" + pname.ToString() + "'='" + s.ToString() + "', " + ex.Message;
                throw new Exception(emsg);
            }
        }

        public void CheckParsedParameters()
        {
            try
            {
                var sb = new StringBuilder();
                #region mandatory
                if (!BCBonusId.HasValue || BCBonusId==0) sb.AppendLine(string.Format("Invalid BCBonusId='{0}',", BCBonusId));
                if (BCBonusName == null) sb.AppendLine(string.Format("Invalid BCBonusName='{0}',", BCBonusName));
                #endregion mandatory

                if (sb.Length > 0)
                    throw new Exception(sb.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
