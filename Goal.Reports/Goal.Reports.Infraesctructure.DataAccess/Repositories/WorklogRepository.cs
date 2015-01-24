using Goal.Reports.Infraesctructure.DataAccess.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Infraesctructure.DataAccess.Repositories
{
    public class WorklogRepository : IRepository
    {

        public IEnumerable ExecuteQuery()
        {
            var tickets = new List<Worklog>();
            tickets.Add(new Worklog() { ID = 132, Wl = 3443, Ticket = "AMS-9229" });
            return tickets;
        }


        public string GetQueryName()
        {
            return "WorklogRepository";
        }
    }
}
