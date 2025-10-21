// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Lezione21_10.Mattina.Es_Print;
using Lezione21_10.Mattina.Esempio_DatabaseService;

class Program
{
  public static void Main(string[] args)
  {
    // var generator = new ReportGenerator();
    // generator.DatabaseService = new SqlDatabaseService();
    // generator.GenerateReport();

    var stampante = new Printer();
    stampante.LoggerPrinter = new LoggerP();
    stampante.Print();
  }
}
