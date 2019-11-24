using System;
using System.Text;
using System.Collections.Generic;
using ConsoleApp1.Enums;

namespace TestCreators.Workers
{
    public class BonusCampaignParameters
    {
        public const long BCBonusIdDefault = -1;
        public const bool BCVCustomerCardOnlyDefault = false;
        public const bool BCSStakeRedeemableDefault = false;
        public long? BCABonusId { get; set; } // > 0 for modify bonus, -1 default for create new bonus if no defined
        public string BCBonusName { get; set; } // mandatory string
        public EnumBonusTypes? BCAType { get; set; } // mandatory, between 1-7
        public int? BCVMinCountOfLegs { get; set; } // mandatory, between 1-777
        public bool? BCVCustomerCardOnly { get; set; } // default false
        public bool? BCSStakeRedeemable { get; set; } // default false

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
                if (d.ContainsKey(pname = "BCAType") && !string.IsNullOrEmpty(s = d[pname])) BCAType = (EnumBonusTypes)Enum.Parse(typeof(EnumBonusTypes), s.Trim());

                if (d.ContainsKey(pname = "BCABonusID") && !string.IsNullOrEmpty(s = d[pname])) BCABonusId = long.Parse(s.Trim());

                if (d.ContainsKey(pname = "BCBonusName") && !string.IsNullOrEmpty(s = d[pname])) BCBonusName = s.Trim();

                if (d.ContainsKey(pname = "BCVMinCountOfLegs") && !string.IsNullOrEmpty(s = d[pname])) BCVMinCountOfLegs = int.Parse(s.Trim());

                if (d.ContainsKey(pname = "BCVCustomerCardOnly") && !string.IsNullOrEmpty(s = d[pname])) BCVCustomerCardOnly = bool.Parse(s.Trim());

                if (d.ContainsKey(pname = "BCSStakeRedeemable") && !string.IsNullOrEmpty(s = d[pname])) BCSStakeRedeemable = bool.Parse(s.Trim());
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
                var sbw = new StringBuilder();
                #region mandatory
                if (BCAType == null || (int)BCAType < 1 || (int)BCAType > 7)
                    sb.AppendLine(string.Format("Invalid BCAType='{0}',", BCAType.ToString()));

                if (!BCABonusId.HasValue || BCABonusId == 0)
                {
                    BCABonusId = BCBonusIdDefault;
                    sbw.AppendLine(string.Format("Set default to BCBonusId='{0}',", BCABonusId.ToString()));
                }

                if (BCBonusName == null)
                    sb.AppendLine(string.Format("Invalid BCBonusName='{0}',", BCBonusName.ToString()));

                if (BCVMinCountOfLegs == null || BCVMinCountOfLegs < 1 || BCVMinCountOfLegs > 777)
                    sb.AppendLine(string.Format("Invalid BCVMinCountOfLegs='{0}',", BCVMinCountOfLegs.ToString()));

                if (!BCVCustomerCardOnly.HasValue)
                {
                    BCVCustomerCardOnly = BCVCustomerCardOnlyDefault;
                    sbw.AppendLine(string.Format("Set default to BCVCustomerCardOnly='{0}',", BCVCustomerCardOnly.ToString()));
                }

                if (!BCSStakeRedeemable.HasValue)
                {
                    BCSStakeRedeemable = BCSStakeRedeemableDefault;
                    sbw.AppendLine(string.Format("Set default to BCSStakeRedeemale='{0}',", BCSStakeRedeemable.ToString()));
                }
                #endregion mandatory

                if (sb.Length > 0)
                    throw new Exception(sb.ToString());
                if (sbw.Length > 0)
                    Console.WriteLine(sbw.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
