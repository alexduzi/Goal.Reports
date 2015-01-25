using Goal.Reports.Controller;
using Goal.Reports.Handler;
using Goal.Reports.Handler.AllWork;
using Goal.Reports.Handler.Handler;
using Goal.Reports.Handler.Handler.Common;
using Goal.Reports.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Controller
{
    internal class AllWorkController : IReportController
    {

        ReportProcessor IReportController.CreateProcessor()
        {
            //create report instances
            ReportProcessor groupWlByDay = new GroupWlByDay();
            ReportProcessor groupCpByDay = new GroupCpByDay();
            ReportProcessor allWorkDrill = new AllWorkDrillReport();
            ReportProcessor allWorkDrillAcc = new AllWorkDrillAccReport();
            ReportProcessor allWork = new AllWorkReport();

            //chain reports
            groupWlByDay.SetSuccessor(groupCpByDay)
                        .SetSuccessor(allWorkDrill)
                        .SetSuccessor(allWorkDrillAcc)
                        .SetSuccessor(allWork);

            return groupWlByDay;
        }

        IEnumerable<IDataExtractor> IReportController.CreateDataExtractor()
        {
            var worklogs = new List<IDataExtractor>();
            worklogs.Add(new TicketsWlRepository());
            worklogs.Add(new TicketsCpRepository());

            return worklogs;
        }
    }
}