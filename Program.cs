using System;
using TestCreators;

namespace ConsoleApp1
{
    class Program
    {
        #region test
        //        static string StepDateFrom { get; set; } = "2019, 11, 19, 11, 10, 21";
        //        static string StepDateTo { get; set; } = "2019, 11, 19, 11, 10, 21";

        //        static void Main_(string[] args)
        //        {
        //            //step params
        //            string stepDateFrom = StepDateFrom;
        //            string stepDateTo = StepDateTo;

        //            //bcp
        //            DateTime? DateFrom;
        //            DateTime? DateTo;

        //            //parse
        //            if (string.IsNullOrEmpty(stepDateFrom))
        //                DateFrom = System.Data.SqlTypes.SqlDateTime.MinValue.Value;
        //            else
        //            {
        //                var a = stepDateFrom.Trim().Split(',');
        //                DateFrom = new DateTime(int.Parse(a[0]), int.Parse(a[1]), int.Parse(a[2]), int.Parse(a[3]), int.Parse(a[4]), int.Parse(a[5]));
        //            }

        //            if (string.IsNullOrEmpty(stepDateTo))
        //                DateTo = System.Data.SqlTypes.SqlDateTime.MaxValue.Value;
        //            else
        //            {
        //                var a = stepDateTo.Trim().Split(',');
        //                DateTo = new DateTime(int.Parse(a[0]), int.Parse(a[1]), int.Parse(a[2]), int.Parse(a[3]), int.Parse(a[4]), int.Parse(a[5]));
        //            }

        //            //check
        //            bool areDateFromToAlowed =  DateTo > DateFrom;
        //            if (!areDateFromToAlowed)
        //            {
        //                Console.WriteLine("areDateFromToAlowed={0}", areDateFromToAlowed);
        //                throw new Exception(string.Format("areDateFromToAlowed={0}", areDateFromToAlowed));
        //            }

        //            //use
        //            Console.WriteLine("areDateFromToAlowed={0}", DateTo > DateFrom);
        //        }
        //    }
        //}
        #endregion test

        static void Main(string[] args)
        {
            var stepParameters = TestData.BCStepParameters;

            Console.WriteLine("Start version:1.0.8.0"+Environment.NewLine);
            using (var bcte = TCCreator.TestEngineBonusCampaign(stepParameters))
            {
                Console.WriteLine("BCAtype: {0}", bcte.BonusCampaignParameters.BCAType);
                Console.WriteLine("BCABonusId: {0}", bcte.BonusCampaignParameters.BCABonusId);
                Console.WriteLine("BCBonusName: {0}", bcte.BonusCampaignParameters.BCBonusName);
                Console.WriteLine("BCVMinCountOfLegs: {0}", bcte.BonusCampaignParameters.BCVMinCountOfLegs);
                Console.WriteLine("BCVCustomerCardOnly: {0}", bcte.BonusCampaignParameters.BCVCustomerCardOnly);
                Console.WriteLine("BCSStakeRedeemable: {0}", bcte.BonusCampaignParameters.BCSStakeRedeemable);
            }
            Console.WriteLine(Environment.NewLine+"Finish version:1.0.8.0");
        }
    }
}
