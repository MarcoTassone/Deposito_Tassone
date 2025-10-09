// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Lezione09_10.Mattina.Es_Operatore;

public class Program
{
  public static void Main(string[] args)
  {
    /// <summary>Esercizio Operatore</summary>


    List<Operatore> operatori = new List<Operatore>();
    bool continua = true;
    string? scelta = " ";
    while (continua)
    {
      Console.WriteLine($"-----Menu Operatori-----");
      Console.WriteLine($"a. Aggiungi operatore emergenza.");
      Console.WriteLine($"b. Aggiungi operatore sicurezza.");
      Console.WriteLine($"c. Aggiungi operatore logistica.");
      Console.WriteLine($"d. Stampa tutti gli operatori.");
      Console.WriteLine($"e. Chiamare EseguiCompito() di tutti.");
      Console.WriteLine($"f. Uscire.");
      scelta = Console.ReadLine();
      
      static void EseguiCompitoTutti(Operatore operatore)  //esegue il compito di tutti gli operatori (non funziona(?))
      {
        Console.WriteLine($"{operatore.Nome}, {operatore.EseguiCompito()}");
      }

      switch (scelta)
      {
        case "a": //inserimento operatore emergenza con parametri nome, turno e livello di emergenza da console
          Console.WriteLine($"Inserisci nome dell'operatore: ");
          string? nomeOE = Console.ReadLine();
          Console.WriteLine($"Inserisci il turno dell'operatore (giorno o notte): ");
          string? turnoOE = Console.ReadLine();
          Console.WriteLine($"Inserisci livello di emergenza (da 1 a 5): ");
          int emergenza = Convert.ToInt32(Console.ReadLine());
          operatori.Add(new OperatoreEmergenza(nomeOE, turnoOE, emergenza));
          break;
        case "b": //inserimento operatore sicurezza con parametri nome, turno e area sorvegliata da console
          Console.WriteLine($"Inserisci nome dell'operatore: ");
          string? nomeOS = Console.ReadLine();
          Console.WriteLine($"Inserisci il turno dell'operatore (giorno o notte): ");
          string? turnoOS = Console.ReadLine();
          Console.WriteLine($"Inserisci area sorvegliata dall'operatore: ");
          string? areaSorvegliata = Console.ReadLine();
          operatori.Add(new OperatoreSicurezza(nomeOS, turnoOS, areaSorvegliata));
          break;
        case "c": //inserimento operatore logistica con parametri nome, turno e numero consegne da console
          Console.WriteLine($"Inserisci nome dell'operatore: ");
          string? nomeOL = Console.ReadLine();
          Console.WriteLine($"Inserisci il turno dell'operatore (giorno o notte): ");
          string? turnoOL = Console.ReadLine();
          Console.WriteLine($"Inserisci il numero consegne dell'operatore (maggiore o uguale a 0): ");
          int numeroConsegne = Convert.ToInt32(Console.ReadLine());
          operatori.Add(new OperatoreLogistica(nomeOL, turnoOL, numeroConsegne));
          break;
        case "d": //stampa tutti gli operatori
          foreach (var operatore in operatori)
          {
            Console.WriteLine($"{operatore.Stampa()}");
          }
          break;
        case "e": //stampa i compiti di tutti gli operatori
          for (int i = 0; i < operatori.Count; i++)
          {
            EseguiCompitoTutti(operatori[i]);
          }
          break;
        case "f":
          continua = false;
          Console.WriteLine($"Arrivederci!");
          break;
      }
    }
  }
}