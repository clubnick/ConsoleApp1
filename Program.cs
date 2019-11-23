using System;
using TestCreators;

namespace ConsoleApp1
{
    class Program
    {
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

        static void Main(string[] args)
        {
            var stepParameters = TestData.BCStepParameters;


            using (var bcte = TCCreator.TestEngineBonusCampaign(stepParameters))
            {

                Console.WriteLine("Start version:1.0.5.2");

                Console.WriteLine("Bonus campaign: {0}", bcte.BonusCampaignParameters.BonusId);
                Console.WriteLine("Bonus campaign: {0}", bcte.BonusCampaignParameters.BonusName);

                Console.WriteLine("Finish}");
            }



            //using (var bcte = TCCreator.TestEngineBonusCampaign())
            //{
            //    Console.WriteLine("Bonus campaign: {0} {1}", bcte.BonusCampaignParameters.BonusId, bcte.BonusCampaignParameters.BonusName);
            //}

            //using (var bcteE = TCCreator.TestEngineBonusCampaignE())
            //{
            //    Console.WriteLine("Bonus campaign: {0} {1}", bcteE.BonusCampaignParameters.BonusId, bcteE.BonusCampaignParameters.BonusName);
            //}

            //using (var bcteFail = TCCreator.TestEngineBonusCampaign_fail())
            //{
            //    Console.WriteLine("Bonus campaign: {0} {1}", bcteFail.BonusCampaignParameters.BonusId, bcteFail.BonusCampaignParameters.BonusName);
            //}
        }
    }
}
