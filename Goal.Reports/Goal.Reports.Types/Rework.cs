using Goal.Reports.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Types
{
    public class Rework : IReport
    {
        public Rework()
        {

        }

        public void execute()
        {
            Console.WriteLine("Exemplo de execução: {0}", DateTime.Now.ToLongDateString());
        }

        public int ID { get; set; }
        public double ComplexityPoint { get; set; }
        public string SprintName { get; set; }
        public string Month { get; set; }
    }
}
