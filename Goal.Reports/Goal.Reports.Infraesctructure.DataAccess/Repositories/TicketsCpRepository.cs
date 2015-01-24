using Goal.Reports.Infraesctructure.DataAccess.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Infraesctructure.DataAccess.Repositories
{
    public class TicketsCpRepository : IRepository
    {

        public IEnumerable ExecuteQuery()
        {
            var tickets = new List<TicketsCp>();
            tickets.Add(new TicketsCp() { ID = 1, CP = 33, Ticket = "AMS-9999" });
            return tickets;
        }


        public string GetQueryName()
        {
            return "TicketsCpRepository";
        }
    }
}
