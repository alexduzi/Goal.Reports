using Goal.Reports.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Handler
{
    internal abstract class ReportProcessor
    {
        protected ReportProcessor successor;

        public ReportProcessor SetSuccessor(ReportProcessor successor)
        {
            this.successor = successor;
            return successor;
        }

        public void Process(ReportRequest request, ReportResponse response) 
        {
            if (this.successor != null)
            {
                Execute(request, response);
                this.successor.Process(request, response);
            } 
            else 
            {
                this.Execute(request, response);
            }
        }

        protected abstract void Execute(ReportRequest request, ReportResponse response);
    }
}