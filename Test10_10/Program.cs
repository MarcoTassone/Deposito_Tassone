// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using Test10_10;

class Program
{
  public static void Main(string[] args)
  {
    List<Animale> animali = new List<Animale>();

    bool continua = true;
    int scelta = 0;
    int tipo = 0;
    while (continua)
    {
      Console.WriteLine($"-----Menu Animale-----");
      Console.WriteLine($"1. Aggiungi un animale.");
      Console.WriteLine($"2. Visualizza tutti gli animali.");
      Console.WriteLine($"3. Emetti verso tutti.");
      Console.WriteLine($"4. Cerca animali per tipo.");
      Console.WriteLine($"5. Esci");
      scelta = int.Parse(Console.ReadLine());

      switch (scelta)
      {
        case 1:
          Console.WriteLine($"Quale tipo di animali vuoi inserire? 1. Cane 2.Gatto");
          tipo = int.Parse(Console.ReadLine());
          //aggiungi un animale con parametri nome, anni e tipo da console
          Console.WriteLine($"Inserisci il nome dell'animale: ");
          string? nome = Console.ReadLine();
          Console.WriteLine($"Inserisci l'anno dell'animale: ");
          int anni = int.Parse(Console.ReadLine());
          if (tipo == 1)
          {
            Console.WriteLine($"Inserisci la razza del cane: ");
            string? razza = Console.ReadLine();
            Animale animale = new Cane(nome, anni, razza);
          }
          else if (tipo == 2)
          {
            Console.WriteLine($"Inserisci il colore del gatto: ");
            string? colore = Console.ReadLine();
            Animale animale = new Gatto(nome, anni, colore);
          } else
          {
            Console.WriteLine($"Scelta non valida");
            
          }
          break;
        case 2:
          for (int i = 0; i < animali.Count; i++)
          {
            Console.WriteLine($"{i} - {animali[i]}");
          }
          break;
        case 3:
          foreach (Animale a in animali)
          {
            a.FaiVerso();
          }
          break;
        case 4:
          Console.WriteLine($"Text");
          break;
      }
    }
  }
}