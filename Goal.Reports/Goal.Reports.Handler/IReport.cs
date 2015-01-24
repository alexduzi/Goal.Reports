using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Handler
{
    public interface IReport
    {
        void Execute(Dictionary<string, object> dictionary);
    }
}
