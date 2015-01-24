using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Infraesctructure.DataAccess.Models
{
    public class Worklog 
    {

        public Worklog()
        {

        }

        public int ID { get; set; }
        public string Ticket { get; set; }
        public double Wl { get; set; }


    }
}
