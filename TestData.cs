using System;
using System.Collections.Generic;
using TestCreators;

namespace ConsoleApp1
{
    public static class TestData
    {

        public static readonly Dictionary<string, string> BCStepParameters
            = new Dictionary<string, string>
        {
          {"BCAType", "1"},
          //{"BCABonusID", "0"},
          {"BCBonusName", "QA(SW)"},
          {"BCVMinCountOfLegs", "1"},
          //{"BCVCustomerCardOnly", "true"}
        };

    };
}
