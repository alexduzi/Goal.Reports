using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Models
{
    public class TicketsCp 
    {
        public TicketsCp()
        {

        }

        public DateTime LogDate { get; set; }
        public string Ticket { get; set; }
        public double CP { get; set; }
    }
}