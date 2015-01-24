using Goal.Reports.Handler;
using Goal.Reports.Types.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Factory.Chains
{
    public class AllWorkChainFactory
    {

        public IReportHandler<AllWork> Execute()
        {

            IReportHandler<AllWork> allWork = new ReportApprover<AllWork>("AllWork");
            IReportHandler<AllWorkDrill> allWorkDrill = new ReportApprover<AllWorkDrill>("AllWorkDrill");
            IReportHandler<AllWorkDrillAcc> allWorkDrillAcc = new ReportApprover<AllWorkDrillAcc>("AllWorkDrillAcc");

            //allWork.SetSuccessor(allWorkDrill);
            //allWorkDrill.SetSuccessor(allWorkDrillAcc);

            return allWork;
        }


    }
}
