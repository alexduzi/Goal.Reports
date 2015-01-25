using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Goal.Reports.Types.Enums;
using Goal.Reports.Handler;

namespace Goal.Reports.Controller
{
    internal static class ReportFactory
    {

        public static IReportController CreateInstance(ReportTypes types)
        {

            if (types == ReportTypes.AllWorkFactory)
            {

                return new AllWorkController();
            }

            throw new NotImplementedException();
        }

    }
}
