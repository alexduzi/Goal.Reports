using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Goal.Reports.Infraesctructure.DataAccess;
using Goal.Reports.Infraesctructure.DataAccess.Models;
using System.Collections;
using Goal.Reports.Types.Enums;
using Goal.Reports.Handler;
using Goal.Reports.Types.Handlers;

namespace Goal.Reports.Factory.Chains
{
    public static class ReportChainFactory
    {

        public static IReportHandler<AllWork> CreateInstance(ReportTypes types)
        {

            if (types == ReportTypes.AllWorkFactory)
            {

                return new AllWorkChainFactory().Execute();
            }

            throw new NotImplementedException();
        }
    }
}
