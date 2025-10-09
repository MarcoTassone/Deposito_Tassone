// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Lezione09_10.Mattina.Es_Operatore;

public class Program
{
  public static void Main(string[] args)
  {
    /// <summary>Esercizio Operatore</summary>


    List<Operatore> operatori = new List<Operatore>();
    Operatore oe = new OperatoreEmergenza(" ", " ", 0);
    bool continua = true;
    string scelta = " ";
    while (continua)
    {
      Console.WriteLine($"-----Menu Operatori-----");
      Console.WriteLine($"a. Aggiungi un nuovo operatore di uno dei tre tipi.");
      Console.WriteLine($"b. Stampa tutti gli operatori.");
      Console.WriteLine($"c. Chiamare EseguiCompito() di tutti.");
      Console.WriteLine($"d. Uscire.");
      scelta = Console.ReadLine();
      switch (scelta)
      {
        case "a":
          if (oe is OperatoreEmergenza)
          {
            Console.WriteLine($"Inserisci il nome dell'operatore: ");
            string? nome = Console.ReadLine();
            Console.WriteLine($"Inserisci il turno dell'operatore: ");
            string? turno = Console.ReadLine();
            Console.WriteLine($"Livello di emergenza gestito: ");
            int emergenza = Convert.ToInt32(Console.ReadLine());
            oe = new OperatoreEmergenza(nome, turno, emergenza);
            operatori.Add(oe);
          }
          break;
        case "b": foreach (Operatore o in operatori) o.Stampa(); break;
        case "c": foreach (Operatore o in operatori) o.EseguiCompito(); break;
        case "d": continua = false; break;
      }
    }
  }
}