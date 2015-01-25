using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Models
{
    internal class TicketsCpMonth 
    {
        public TicketsCpMonth()
        {

        }

        public DateTime LogDate { get; set; }
        public string Ticket { get; set; }
        public double CP { get; set; }
        public double WL { get; set; }
    }
}