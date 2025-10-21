// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Lezione21_10.Mattina.Es_DI_e_Factory;
using Lezione21_10.Mattina.Es_Print;
using Lezione21_10.Mattina.Es_StorageService;
using Lezione21_10.Mattina.Esempio_DatabaseService;

class Program
{
  public static void Main(string[] args)
  {

    #region Esempio_DatabaseService
    // var generator = new ReportGenerator();
    // generator.DatabaseService = new SqlDatabaseService();
    // generator.GenerateReport();
    #endregion

    #region Es_Print
    // var stampante = new Printer();
    // stampante.LoggerPrinter = new LoggerP();
    // stampante.Print();
    #endregion

    #region Es_StorageService
    // var save = new FileUploader();


    // Console.WriteLine($"Inserire nome del file: ");
    // string? nomeFile = Console.ReadLine();
    // Console.WriteLine($"Dove vuoi salvare il file? (disk/memory): ");
    // string? metodo = Console.ReadLine();

    // switch (metodo)
    // {
    //   case "disk":
    //     save.StorageService = new DiskService();
    //     save.Salvataggio(nomeFile, metodo);
    //     break;
    //   case "memory":
    //     save.StorageService = new MemoryService();
    //     save.Salvataggio(nomeFile, metodo);
    //     break;
    // }
    #endregion

    #region Es_DI_e_Factory

    bool continua = true;
    int scelta;

    while (continua)
    {
      Console.WriteLine($"--------Benvenuto!--------");
      Console.WriteLine($"1 - Crea libro fisico");
      Console.WriteLine($"2 - Crea libro digitale");
      Console.WriteLine($"3 - Inserisci quantità");
      
      Console.WriteLine($"3 - Esci");
      scelta = Convert.ToInt32(Console.ReadLine());

      switch (scelta)
      {
        case 1:

      }
    }
    #endregion

  }
}
