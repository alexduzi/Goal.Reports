using Goal.Reports.Handler.Specification;
using Goal.Reports.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Goal.Reports.Handler.SpecificationUtils;
using Goal.Reports.Handler;
using Goal.Reports.Factory;
using Goal.Reports.Types.Enums;
using Goal.Reports.Infraesctructure.DataAccess;
using Goal.Reports.Factory.DataAcess;

namespace Goal.Reports.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            //### EXEMPLOS DE UTILIZAÇÃO!

            //viria o manager
            //carregamos um lista com alguns dados e o tipo deles são relatórios
            ////List<Rework> relatorios = new List<Rework>();


            //setar especificações para o report com o specification pattern
            //IReportSpecification<Rework> reworkSpec =
            //    new ReportSpecification<Rework>(report => report.SprintName.Equals("Sprint 1"));

            //IReportSpecification<Account> accSpec =
            //    new ReportSpecification<Account>(account => account.Money > 1000);

            //IReportHandler<Rework> rework = new ReportApprover<Rework>("Rework");

            //rework.SetSpecification(reworkSpec);

            //rework.SetSuccessor(worklog);


           

            //informaçao vem do banco
            var reportType = ReportTypes.AllWorkFactory;

            ManagerCall(reportType);
        }

        private static void ManagerCall(ReportTypes reportType)
        {
            var reportInstance = ReportFactory.CreateInstance(reportType);

            Dictionary<string, object> dictonary = new Dictionary<string, object>();

            var repos = reportInstance.Iterator();
            foreach (IRepository repo in repos)
            {
                var repository = repo.ExecuteQuery();
                dictonary.Add(repo.GetQueryName(), repository);
            }

            //criar handler

            System.Console.ReadKey();
        }

        

    }
}
