using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Handler.Specification
{
    public interface IReportSpecification<T>
    {
        bool IsSatisfiedBy(T o);
    }
}
