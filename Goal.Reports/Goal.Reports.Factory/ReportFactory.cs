using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Goal.Reports.Infraesctructure.DataAccess;
using Goal.Reports.Infraesctructure.DataAccess.Models;
using System.Collections;
using Goal.Reports.Types.Enums;

namespace Goal.Reports.Factory
{
    public static class ReportFactory
    {

        public static IReportIterator CreateInstance(ReportTypes types)
        {

            if (types == ReportTypes.AllWorkFactory)
            {
                return new AllWorkFactory();
            }

            throw new NotImplementedException();
        }


    }

    

}
