// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Lezione16_10.Mattina;
using Lezione16_10.Mattina.StrategiaOperazione;
using Lezione16_10.Mattina.StrategiaPiatti;

class Program
{
  public static void Main(string[] args)
  {
    // var context = new Context();

    //     // Usa la strategia di somma
    //     context.SetStrategy(new ConcreteStrategyAdd());
    //     Console.Write("Somma: ");
    //     context.ExecuteStrategy(10, 5);  // Output: 15

    //     // Cambia strategia in sottrazione
    //     context.SetStrategy(new ConcreteStrategySubtract());
    //     Console.Write("Sottrazione: ");
    //     context.ExecuteStrategy(10, 5);  // Output: 5

    //     // Cambia strategia in moltiplicazione
    //     context.SetStrategy(new ConcreteStrategyMultiply());
    //     Console.Write("Moltiplicazione: ");
    //     context.ExecuteStrategy(10, 5);  // Output: 50

    // var operazione = new Calcolatrice();
    // Utente utente = Utente.GetInstance();


    // bool continua = true;
    // int scelta;

    // while (continua)
    // {
    //   // chiediamo quale operazione eseguire
    //   Console.WriteLine($"----Menu operazioni----");
    //   Console.WriteLine($"1. Addizione");
    //   Console.WriteLine($"2. Sottrazione");
    //   Console.WriteLine($"3. Moltiplicazione");
    //   Console.WriteLine($"4. Divisione");
    //   Console.WriteLine($"5. Esci");
    //   scelta = Convert.ToInt32(Console.ReadLine());

    //   switch (scelta)
    //   {
    //     case 1:
    //       Console.WriteLine($"Inserisci i numeri da sommare.");
    //       double sum1 = Convert.ToDouble(Console.ReadLine());
    //       Console.WriteLine($"Primo numero inserito.");
    //       double sum2 = Convert.ToDouble(Console.ReadLine());
    //       Console.WriteLine($"Secondo numero inserito.");
    //       operazione.ImpostaStrategia(new SommaStrategia()); //impostiamo la strategia di somma
    //       operazione.EseguiOperazione(sum1, sum2); //eseguiamo l'operazione
    //       break;
    //     case 2: 
    //       Console.WriteLine($"Inserisci i numeri da sottrarre.");
    //       double sub1 = Convert.ToDouble(Console.ReadLine());
    //       Console.WriteLine($"Primo numero inserito.");
    //       double sub2 = Convert.ToDouble(Console.ReadLine());
    //       Console.WriteLine($"Secondo numero inserito.");
    //       operazione.ImpostaStrategia(new SottrazioneStrategia());
    //       operazione.EseguiOperazione(sub1, sub2);
    //       break;
    //     case 3:
    //       Console.WriteLine($"Inserisci i numeri da moltiplicare.");
    //       double mult1 = Convert.ToDouble(Console.ReadLine());
    //       Console.WriteLine($"Primo numero inserito.");
    //       double mult2 = Convert.ToDouble(Console.ReadLine());
    //       Console.WriteLine($"Secondo numero inserito.");
    //       operazione.ImpostaStrategia(new MoltiplicazioneStrategia());
    //       operazione.EseguiOperazione(mult1, mult2);
    //       break;
    //     case 4:
    //       Console.WriteLine($"Inserisci i numeri da dividere.");
    //       double div1 = Convert.ToDouble(Console.ReadLine());
    //       Console.WriteLine($"Primo numero inserito.");
    //       double div2 = Convert.ToDouble(Console.ReadLine());
    //       Console.WriteLine($"Secondo numero inserito.");
    //       operazione.ImpostaStrategia(new DivisioneStrategia());
    //       operazione.EseguiOperazione(div1, div2);
    //       break;
    //     case 5:
    //       Console.WriteLine($"Arrivederci!");
    //       continua = false;
    //       break;
    //     default:
    //       Console.WriteLine($"Scelta non valida.");
    //       break;
    //   }
    // }

    var strategiaPreparazione = new Chef();

    bool continua = true;
    string? scelta;

    while (continua)
    {
      Console.WriteLine($"----Menu preparazione----");
      Console.WriteLine($"1. Pizza");
      Console.WriteLine($"2. Hamburger");
      Console.WriteLine($"2. Insalata");
      Console.WriteLine($"3. Esci");
      scelta = Console.ReadLine();

      switch (scelta)
      {
        case "pizza":
          IPiatto piattoPizza = PiattoFactory.Crea(scelta); //sbagliato
          break;
        case "hamburger":
          IPiatto piattoHamburger = PiattoFactory.Crea(scelta);
          break;
        case "insalata":
          IPiatto piattoInsalata = PiattoFactory.Crea(scelta);
          break;
        case "esci":
          Console.WriteLine($"Arrivederci!");
          continua = false;
          continue;
      }

      bool ingredienti = true;

      while (ingredienti)
      {
        Console.WriteLine($"Vuoi aggiungere un ingrediente? (s/n)");
        string? risposta = Console.ReadLine();
        if (risposta == "n")
        {
          ingredienti = false;
        } else
        {
          Console.WriteLine($"1. Formaggio");
          Console.WriteLine($"2. Pomodori");
          Console.WriteLine($"2. Maionese");
          Console.WriteLine($"3. Esci");
          int sceltaIngredienti = Convert.ToInt32(Console.ReadLine());

          switch (sceltaIngredienti)
          {
            case 1:
              
              break;
            case 2:
              
              break;
            case 3:
              
              break;
            case 4:
              Console.WriteLine($"Arrivederci!");
              continua = false;
              continue;
          }
        }
        
      }
    }
  }
}
