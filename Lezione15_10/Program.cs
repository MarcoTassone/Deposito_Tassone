// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Lezione15_10.Mattina;
using Lezione15_10.Mattina.Es_Observer;

class Program
{
  public static void Main(string[] args)
  {

    /// <summary>Esempio observer</summary>
    // var subject = new ConcreteSubject();

    // var observerA = new ConcreteObserver("Observer A");
    // var observerB = new ConcreteObserver("Observer B");

    // // Registrazione degli observer
    // subject.Attach(observerA);
    // subject.Attach(observerB);

    // // Cambia lo stato: innesca Notify() e chiama Update() su tutti gli observer
    // subject.State = 5;
    // subject.State = 10;

    // // Rimuove un observer
    // subject.Detach(observerA);

    // // Ancora un cambiamento di stato: solo Observer B verrà notificato
    // subject.State = 15;


    /// <summary>Esercizio Observer meteo</summary>

    var subject = new CentroMeteo();

    var displayConsole = new DisplayConsole();
    var displayMobile = new DisplayMobile();

    bool continua = true;
    int scelta;

    while (continua)
    {
      Console.WriteLine($"-----Menu Meteo-----");
      Console.WriteLine($"1. Inserisci meteo.");
      Console.WriteLine($"2. Aggiorna observer.");
      Console.WriteLine($"3. Esci.");
      scelta = Convert.ToInt32(Console.ReadLine());

      switch (scelta)
      {
        case 1:
          Console.WriteLine($"Inserisci il meteo: ");
          string? meteo = Console.ReadLine();
          displayConsole.Aggiorna(meteo);
          displayMobile.Aggiorna(meteo);
          break;
        case 2:
          Console.WriteLine($"Aggiorna meteo.");
          string? meteoAggiornato = Console.ReadLine();
          subject.AggiornaMeteo(meteoAggiornato);
          displayConsole.Aggiorna(meteoAggiornato);
          displayMobile.Aggiorna(meteoAggiornato);
          break;
        case 3:
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
