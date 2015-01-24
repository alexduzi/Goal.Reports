using Goal.Reports.Handler.Specification;
using Goal.Reports.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Goal.Reports.Handler.SpecificationUtils;
using Goal.Reports.Handler;

namespace Goal.Reports.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            //### EXEMPLOS DE UTILIZAÇÃO!

            //setar especificações para o report com o specification pattern
            IReportSpecification<Rework> reworkSpec = 
                new ReportSpecification<Rework>(report => report.SprintName.Equals("Sprint 1"));


            
            IReportHandler<Rework> rework = new ReportApprover<Rework>("Rework");

            
            rework.SetSpecification(reworkSpec);

            //
            //rework.SetSuccessor();

        }

        

    }
}
