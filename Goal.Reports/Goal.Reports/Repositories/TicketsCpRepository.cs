using Goal.Reports.Models;
using Goal.Reports.Types.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Repositories
{
    internal class TicketsCpRepository : IDataExtractor
    {

        public IEnumerable ExecuteQuery()
        {
            var list = new List<TicketsCp>();
            list.Add(new TicketsCp() { LogDate = new DateTime(2015,01,01), CP = 5, Ticket = "AMS-9999" });
            list.Add(new TicketsCp() { LogDate = new DateTime(2015, 01, 02), CP = 2, Ticket = "AMS-1234" });
            list.Add(new TicketsCp() { LogDate = new DateTime(2015, 01, 05), CP = 1, Ticket = "AMS-1515" });
            list.Add(new TicketsCp() { LogDate = new DateTime(2015, 01, 01), CP = 3, Ticket = "AMS-1717" });
            list.Add(new TicketsCp() { LogDate = new DateTime(2015, 01, 05), CP = 9, Ticket = "AMS-9999" });
            return list;
        }

        public string GetName()
        {
            return this.GetType().Name;
        }

        public Type GetRowType()
        {
            return typeof(IEnumerable<TicketsCp>);
        }
    }
}