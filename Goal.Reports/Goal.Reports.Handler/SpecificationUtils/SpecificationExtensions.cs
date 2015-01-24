using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Goal.Reports.Handler.Specification;

namespace Goal.Reports.Handler.SpecificationUtils
{
    public static class SpecificationExtensions
    {
        public static ReportSpecification<T> And<T>(this IReportSpecification<T> left, IReportSpecification<T> right)
        {
            return new ReportSpecification<T>(o => left.IsSatisfiedBy(o) && right.IsSatisfiedBy(o));
        }
        public static ReportSpecification<T> Or<T>(this IReportSpecification<T> left, IReportSpecification<T> right)
        {
            return new ReportSpecification<T>(o => left.IsSatisfiedBy(o) || right.IsSatisfiedBy(o));
        }
        public static ReportSpecification<T> Not<T>(this IReportSpecification<T> left)
        {
            return new ReportSpecification<T>(o => !left.IsSatisfiedBy(o));
        }
    } 
}
