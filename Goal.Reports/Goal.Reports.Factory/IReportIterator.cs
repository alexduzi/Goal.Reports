using Goal.Reports.Infraesctructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Factory
{
    public interface IReportIterator
    {
        IEnumerable<IRepository> Iterator();
    }
}
