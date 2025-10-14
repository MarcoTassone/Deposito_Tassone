// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Lezione14_10.Mattina;
using Lezione14_10.Mattina.FactoryMethod;
using Lezione14_10.Mattina.FactoryMethod.Es_IVeicolo;

class Program
{
  public static void Main(string[] args)
  {
    // ConfigurazioneSistema ModuloA = ConfigurazioneSistema.Istance;
    // ConfigurazioneSistema ModuloB = ConfigurazioneSistema.Istance;

    // ModuloA.Imposta("chiave1", "valore1");
    // ModuloB.Imposta("chiave2", "valore2");

    // Console.WriteLine($"cose :  {ModuloA.Leggi("chiave1")}");
    // Console.WriteLine($"HashCode ModuloA: {ModuloA.GetHashCode()}");
    // Console.WriteLine($"HashCode ModuloB: {ModuloB.GetHashCode()}");
    // Console.WriteLine($"Sono uguali? {Object.Equals(ModuloA, ModuloB)}");

    // ConfigurazioneSistema.Istance.StampaTutte();

    // Creator creatorA = new ConcreteCreatorA();
    // creatorA.AnOperation();  // Usa ConcreteProductA

    // Creator creatorB = new ConcreteCreatorB();
    // creatorB.AnOperation();  // Usa ConcreteProductB

    bool continua = true;
    int scelta;

    while (continua)
    {
      Console.WriteLine($"-----Menu-----");
      Console.WriteLine($"1. Inserire quale veicolo creare.");
      Console.WriteLine($"2. Uscire.");
      scelta = int.Parse(Console.ReadLine());

      switch (scelta){
        case 1:
          Console.WriteLine($"Che tipo di veicolo vuoi creare?\n 1.Auto\n2.Moto\n3.Camion");
          string? sceltaVeicolo = Console.ReadLine().ToLower();
          Iveicolo veicolo = VeicoloFactory.CreateVeicolo(sceltaVeicolo);

          if (veicolo != null)
          {
            veicolo.Avvia();
            veicolo.MostraTipo();
          }
          else
          {
            Console.WriteLine($"Tipo di veicolo non valido.");
          }
          break;
        case 2:
          Console.WriteLine($"Arrivederci!");
          continua = false;
          break;
        default:
          Console.WriteLine($"Scelta non valida.");
          break;
      }
    }
  }
}