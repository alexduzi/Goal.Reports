using Goal.Reports.Handler.AllWork;
using Goal.Reports.Handler.Models;
using Goal.Reports.Models;
using Goal.Reports.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Handler.Handler.Common
{
    internal class GroupWlByDay : ReportProcessor
    {

        protected override void Execute(Types.ReportRequest request, Types.ReportResponse response)
        {
            IEnumerable<TicketsWl> ticketsWl = request.getData<List<TicketsWl>>("TicketsWlRepository");

            IEnumerable<DataByDay> ticketsWlDay = from tcp in ticketsWl
                    group tcp by tcp.LogDate.ToString("MM/dd/yyyy") into grp
                    select new DataByDay{ Day = grp.Key, Value = grp.Sum(tcp => tcp.WL) };

            Console.WriteLine("Wl by day");
            foreach (DataByDay tcd in ticketsWlDay) 
            {
                Console.WriteLine(tcd.Day + " - " + tcd.Value);
            }

            request.AddData(this.GetType().Name, typeof(IEnumerable<DataByDay>), ticketsWlDay);
        }
    }
}
