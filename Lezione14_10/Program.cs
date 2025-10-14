// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Lezione14_10.Mattina;

class Program
{
  public static void Main(string[] args)
  {
    ConfigurazioneSistema ModuloA = ConfigurazioneSistema.Istance;
    ConfigurazioneSistema ModuloB = ConfigurazioneSistema.Istance;

    ModuloA.Imposta("chiave1", "valore1");
    ModuloB.Imposta("chiave2", "valore2");

    Console.WriteLine($"cose :  {ModuloA.Leggi("chiave1")}");
    
    ConfigurazioneSistema.Istance.StampaTutte();
  }
}