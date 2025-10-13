// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using Lezione13_10.Pomeriggio.Logger;

class Program
{
  public static void Main(string[] args)
  {
    Logger logger = Logger.GetIstanza();
    Logger.ScriviMessaggio("Ciao");

    Logger logger1 = Logger.GetIstanza();
    Logger.ScriviMessaggio("bau");

    NonLoSo();

    Console.WriteLine($"HashCode logger: {logger.GetHashCode()}");
    Console.WriteLine($"HashCode logger1: {logger1.GetHashCode()}");
    Console.WriteLine($"Sono uguali? {Object.Equals(logger, logger1)}");



    Utente u1 = new Utente("Bob");
    Utente u2 = new Utente("Bob");

    u1.Azione("Reset");
    u2.Azione("Login");
    
    Logger l1 = Logger.GetIstanza();
    Logger l2 = Logger.GetIstanza();
    
    Console.WriteLine($"Sono uguali? {Object.Equals(l1, l2)}");

  }
  
  static void NonLoSo()
  {
    Logger logger = Logger.GetIstanza();
    Logger.ScriviMessaggio("Non lo so");
  }
}