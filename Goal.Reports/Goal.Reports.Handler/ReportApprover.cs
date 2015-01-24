using Goal.Reports.Handler.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Handler
{
    public class ReportApprover<T> : 
        IReportHandler<T> where T : IReport
    {
        private IReportHandler<T> successor;
        private string name;
        private IReportSpecification<T> specification;
        public ReportApprover(string name)
        {
            this.name = name;
        }

        public bool CanHandle(T o, Dictionary<string, object> dictionary)
        {
            return this.specification.IsSatisfiedBy(o);
        }

        public void SetSuccessor(IReportHandler<T> handler)
        {
            this.successor = handler;
        }

        public void HandleRequest(T o, Dictionary<string, object> dictionary)
        {
            if (CanHandle(o, dictionary))
            {
                o.Execute(dictionary);
                
            }
            else
            {
                this.successor.HandleRequest(o, dictionary);
            }
        }

        public void SetSpecification(IReportSpecification<T> specification)
        {
            this.specification = specification;
        }

    } 
}
