using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione21_10.Mattina.Esempio_DatabaseService
{
    public interface IDatabaseService
    {
        void Connect();
    }

    public class SqlDatabaseService : IDatabaseService
    {
        public void Connect()
        {
            Console.WriteLine("Connessione al database SQL stabilita.");
        }
    }

    public class ReportGenerator
    {
        public IDatabaseService? DatabaseService { get; set; }

        public void GenerateReport()
        {
            if (DatabaseService == null)
            {
                Console.WriteLine("DatabaseService non impostato.");
                return;
            }

            DatabaseService.Connect();
            Console.WriteLine("Generazione report in corso...");
        }
    }
}