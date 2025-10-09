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
      switch (scelta)
      {
        case "a":
          Console.WriteLine($"Inserisci nome dell'operatore: ");
          string? nomeOE = Console.ReadLine();
          Console.WriteLine($"Inserisci il turno dell'operatore: ");
          string? turnoOE = Console.ReadLine();
          Console.WriteLine($"Inserisci livello di emergenza: ");
          int emergenza = Convert.ToInt32(Console.ReadLine());
          operatori.Add(new OperatoreEmergenza(nomeOE, turnoOE, emergenza));
          break;
        case "b":
          Console.WriteLine($"Inserisci nome dell'operatore: ");
          string? nomeOS = Console.ReadLine();
          Console.WriteLine($"Inserisci il turno dell'operatore: ");
          string? turnoOS = Console.ReadLine();
          Console.WriteLine($"Inserisci area sorvegliata dall'operatore: ");
          string? areaSorvegliata = Console.ReadLine();
          operatori.Add(new OperatoreSicurezza(nomeOS, turnoOS, areaSorvegliata));
          break;
        case "c":
          Console.WriteLine($"Inserisci nome dell'operatore: ");
          string? nomeOL = Console.ReadLine();
          Console.WriteLine($"Inserisci il turno dell'operatore: ");
          string? turnoOL = Console.ReadLine();
          Console.WriteLine($"Inserisci il numero consegne dell'operatore: ");
          int numeroConsegne = Convert.ToInt32(Console.ReadLine());
          break;
        case "d":
          break;
      }
    }
  }
}