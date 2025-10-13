// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using Lezione13_10.Pomeriggio.Logger;
using Lezione13_10.Pomeriggio.Logger_con_lista;

class Program
{
  public static void Main(string[] args)
  {

    /// <summary>Esercizio logger</summary>

    // Logger logger = Logger.GetIstanza();
    // logger.ScriviMessaggio("Ciao");

    // Logger logger1 = Logger.GetIstanza();
    // logger1.ScriviMessaggio("bau");

    // NonLoSo();

    // Console.WriteLine($"HashCode logger: {logger.GetHashCode()}");
    // Console.WriteLine($"HashCode logger1: {logger1.GetHashCode()}");
    // Console.WriteLine($"Sono uguali? {Object.Equals(logger, logger1)}");



    // Utente u1 = new Utente("Bob");
    // Utente u2 = new Utente("Bob");

    // u1.Azione("Reset");
    // u2.Azione("Login");

    // Logger l1 = Logger.GetIstanza();
    // Logger l2 = Logger.GetIstanza();

    // Console.WriteLine($"Sono uguali? {Object.Equals(l1, l2)}");


    /// <summary>Esercizio logger con lista</summary>

    LoggerList loggerList = LoggerList.Istanza;
    LoggerList loggerList2 = LoggerList.Istanza;

    loggerList.Log("Ciao");
    loggerList2.Log("Bau");
    LoggerList.Istanza.StampaLog();

    // loggerList.Log("Ciao");  ///anche questo funziona
    // loggerList2.StampaLog();
  }
  
  /// <summary>Metodo usato per logger senza lista</summary>
  
  // static void NonLoSo()
  // {
  //   Logger logger = Logger.GetIstanza();
  //   logger.ScriviMessaggio("Non lo so");
  // }
}