using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Handler
{
    public abstract class ReportHandler<T>
    {
        protected ReportHandler<T> successor;

        public void SetSuccessor(ReportHandler<T> successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(ReportHandler<T> report);

    }
}
