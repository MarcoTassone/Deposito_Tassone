// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Lezione20_10.Mattina;

class Program
{
  public static void Main(string[] args)
  {
    var context = BankContext.GetIstance();
    context.AddObserver(new ConsoleLogger());

    bool continua = true;
    int scelta;

    while (continua)
    {
      Console.WriteLine($"-----Menu Banca-----");
      Console.WriteLine($"1. Crea cliente.");
      Console.WriteLine($"2. Crea conto.");
      Console.WriteLine($"3. Deposita.");
      Console.WriteLine($"4. Preleva.");
      Console.WriteLine($"5. Trasferisci.");
      Console.WriteLine($"6. Mostra i saldi.");
      scelta = Convert.ToInt32(Console.ReadLine());

      switch (scelta)
      {
        case 1:
          Console.WriteLine($"Inserisci il nome dell'utente: ");
          string? nome = Console.ReadLine();
          Console.WriteLine($"Inserisci l'email dell'utente: ");
          string? email = Console.ReadLine();
          ServizioBancario.CreaCliente(nome, email);
          break;
        case 2:
          Console.WriteLine("inserire l'id del cliente di cui vuoi creare il conto: ");
          int id = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("inserire il tipo di conto (base/premium/studente): ");
          string? tipo = Console.ReadLine();
          ServizioBancario.CreaConto(id, tipo);
          
          break;
        case 3:
          Console.WriteLine("inserire l'id del conto in cui vuoi depositare l'importo: ");
          int idConto = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("inserire l'importo da depositare: ");
          decimal importo = Convert.ToDecimal(Console.ReadLine());
          ServizioBancario.Deposita(idConto, importo);
          break;
        case 4:
          Console.WriteLine("inserire l'id del conto da cui vuoi prelevare l'importo: ");
          idConto = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("inserire l'importo da prelevare: ");
          importo = Convert.ToDecimal(Console.ReadLine());
          ServizioBancario.Preleva(idConto, importo);
          break;
        case 5:
          Console.WriteLine($"inserire l'id del conto dal quale vuoi prelevare i soldi: ");
          int fromId = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine($"inserire l'id del conto in cui vuoi trasferire i soldi: ");
          int toId = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine($"inserire l'importo da trasferire: ");
          importo = Convert.ToDecimal(Console.ReadLine());
          ServizioBancario.Trasferisci(fromId, toId, importo);
          break;
        case 6:
          ServizioBancario.MostraSaldi();
          break;
      }
    }
  }
}