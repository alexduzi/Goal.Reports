using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Models
{
    internal class TicketsWl 
    {

        public TicketsWl()
        {

        }

        public DateTime LogDate { get; set; }
        public string Ticket { get; set; }
        public double WL { get; set; }


    }
}
