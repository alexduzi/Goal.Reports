using Goal.Reports.Handler.AllWork;
using Goal.Reports.Handler.Models;
using Goal.Reports.Models;
using Goal.Reports.Repositories;
using Goal.Reports.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Handler.Handler.Common
{
    internal class GroupCpByDay : ReportProcessor
    {

        protected override void Execute(Types.ReportRequest request, Types.ReportResponse response)
        {
            IEnumerable<TicketsCp> ticktesCp = request.getData<List<TicketsCp>>("TicketsCpRepository");
            
            IEnumerable<DataByDay> ticketsCpDay = from tcp in ticktesCp
                    group tcp by tcp.LogDate.ToString("MM/dd/yyyy") into grp
                    select new DataByDay{ Day = grp.Key, Value = grp.Sum(tcp => tcp.CP) };

            Console.WriteLine("CP by day");
            foreach(DataByDay tcd in ticketsCpDay) 
            {
                Console.WriteLine(tcd.Day + " - " + tcd.Value);
            }

            request.AddData(this.GetType().Name, typeof(IEnumerable<DataByDay>), ticketsCpDay);
        }
    }
}
