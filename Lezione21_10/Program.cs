// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Lezione21_10.Mattina.Es_Print;
using Lezione21_10.Mattina.Es_StorageService;
using Lezione21_10.Mattina.Esempio_DatabaseService;

class Program
{
  public static void Main(string[] args)
  {
    // var generator = new ReportGenerator();
    // generator.DatabaseService = new SqlDatabaseService();
    // generator.GenerateReport();

    // var stampante = new Printer();
    // stampante.LoggerPrinter = new LoggerP();
    // stampante.Print();

    var save = new FileUploader();


    Console.WriteLine($"Inserire nome del file: ");
    string? nomeFile = Console.ReadLine();
    Console.WriteLine($"Dove vuoi salvare il file? (disk/memory): ");
    string? metodo = Console.ReadLine();

    switch (metodo)
    {
      case "disk":
        save.StorageService = new DiskService();
        save.Salvataggio(nomeFile, metodo);
        break;
      case "memory":
        save.StorageService = new MemoryService();
        save.Salvataggio(nomeFile, metodo);
        break;
    }
  }
}
