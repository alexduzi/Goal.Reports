using Goal.Reports.Infraesctructure.DataAccess.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Infraesctructure.DataAccess
{
    public interface IRepository
    {
        IEnumerable ExecuteQuery();
        string GetQueryName();
    }
}
