using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Handler.Specification
{
    public class ReportSpecification<T> : IReportSpecification<T>
    {
        private Func<T, bool> expression;
        public ReportSpecification(Func<T, bool> expression)
        {
            //TODO DUZI: verificar melhor implementação, talvez um null object pattern?
            if (expression == null)
                throw new ArgumentNullException(); 
            else
                this.expression = expression;
        }

        public bool IsSatisfiedBy(T o)
        {
            return this.expression(o);
        }
    }  
}
