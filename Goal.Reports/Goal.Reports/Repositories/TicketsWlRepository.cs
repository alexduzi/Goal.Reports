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
    internal class TicketsWlRepository : IDataExtractor
    {

        public IEnumerable ExecuteQuery()
        {
            var list = new List<TicketsWl>();
            list.Add(new TicketsWl() { LogDate = new DateTime(2015, 01, 01), WL = 3600, Ticket = "AMS-7777" });
            list.Add(new TicketsWl() { LogDate = new DateTime(2015, 01, 02), WL = 7200, Ticket = "AMS-1010" });
            list.Add(new TicketsWl() { LogDate = new DateTime(2015, 01, 05), WL = 14400, Ticket = "AMS-1515" });
            list.Add(new TicketsWl() { LogDate = new DateTime(2015, 01, 01), WL = 3300, Ticket = "AMS-1717" });
            list.Add(new TicketsWl() { LogDate = new DateTime(2015, 01, 05), WL = 1800, Ticket = "AMS-9999" });
            return list;
        }

        public string GetName()
        {
            return this.GetType().Name;
        }

        public Type GetRowType()
        {
            return typeof(IEnumerable<TicketsWl>);
        }
    }

}