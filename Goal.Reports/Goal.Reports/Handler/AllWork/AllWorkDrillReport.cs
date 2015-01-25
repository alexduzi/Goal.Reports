using Goal.Reports.Handler;
using Goal.Reports.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Handler.AllWork
{
    internal class AllWorkDrillReport : ReportProcessor
    {

        protected override void Execute(ReportRequest request, ReportResponse response)
        {
            Console.WriteLine("Executando All Work Drill");
        }
    }
}
