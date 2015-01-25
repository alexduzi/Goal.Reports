using Goal.Reports.Types.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Repositories
{
    internal interface IDataExtractor
    {
        IEnumerable ExecuteQuery();
        string GetName();
        Type GetRowType();
    }
}
