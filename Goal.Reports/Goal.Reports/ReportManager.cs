using Goal.Reports.Controller;
using Goal.Reports.Handler;
using Goal.Reports.Repositories;
using Goal.Reports.Types;
using Goal.Reports.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Manager
{
    public class ReportManager
    {

        public ReportResponse generateReport(ReportTypes reportType)
        {
            IReportController controller = ReportFactory.CreateInstance(reportType);
            var request = new ReportRequest();

            IEnumerable<IDataExtractor> repos = controller.CreateDataExtractor();
            foreach (IDataExtractor repo in repos)
            {
                var repository = repo.ExecuteQuery();
                request.AddData(repo.GetName(), repo.GetType(), repository);
            }

            ReportResponse response = new ReportResponse();
            ReportProcessor chain = controller.CreateProcessor();
            chain.Process(request, response);

            return response;
        }
    }
}
