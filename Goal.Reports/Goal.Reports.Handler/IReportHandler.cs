using Goal.Reports.Handler.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Handler
{
    public interface IReportHandler<T>
    {
        void SetSuccessor(IReportHandler<T> handler);
        void HandleRequest(T o, Dictionary<string, object> dictionary);
        void SetSpecification(IReportSpecification<T> specification);
    }
}
