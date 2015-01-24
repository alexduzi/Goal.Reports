using Goal.Reports.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Types.Handlers
{
    public class ReworkHandler : IReportHandler<Rework>
    {

        public void SetSuccessor(IReportHandler<Rework> handler)
        {
            throw new NotImplementedException();
        }

        public void HandleRequest(Rework o)
        {
            throw new NotImplementedException();
        }

        public void SetSpecification(Handler.Specification.IReportSpecification<Rework> specification)
        {
            throw new NotImplementedException();
        }
    }
}
