using Goal.Reports.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Types.Handlers
{
    public class AllWork : IReport
    {
        public void Execute(Dictionary<string, object> dictionary)
        {
            Console.WriteLine("Executando All Work");
        }
    }
}
