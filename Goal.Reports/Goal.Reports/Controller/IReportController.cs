using Goal.Reports.Handler;
using Goal.Reports.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Controller
{
    internal interface IReportController
    {
        IEnumerable<IDataExtractor> CreateDataExtractor();
        ReportProcessor CreateProcessor();
    }
}
