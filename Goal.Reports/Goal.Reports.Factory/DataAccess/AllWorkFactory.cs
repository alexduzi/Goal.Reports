using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Goal.Reports.Infraesctructure.DataAccess;
using Goal.Reports.Infraesctructure.DataAccess.Models;
using Goal.Reports.Infraesctructure.DataAccess.Repositories;
using Goal.Reports.Factory.DataAcess;

namespace Goal.Reports.Factory.DataAccess
{
    public class AllWorkFactory : IReportIterator
    {


        public IEnumerable<IRepository> Iterator()
        {
            var worklogs = new List<IRepository>();
            worklogs.Add(new WorklogRepository());
            worklogs.Add(new TicketsCpRepository());

            return worklogs;
        }
    }
}
