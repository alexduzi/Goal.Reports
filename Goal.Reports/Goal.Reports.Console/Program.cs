using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Goal.Reports.Types.Enums;
using Goal.Reports.Manager;

namespace Goal.Reports.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var reportType = ReportTypes.AllWorkFactory;

            ReportManager manager = new ReportManager();
            manager.generateReport(reportType);

            System.Console.ReadKey();
        }

    }
}