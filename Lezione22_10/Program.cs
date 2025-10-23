// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Security.Authentication.ExtendedProtection;
using Domain;
using Infrastructure;
using Application;
using Lezione22_10.Mattina;

class Program
{
  public static void Main(string[] args)
  {
    // new ConsoleUI(new ProdottoService(new ProdottoRepositoryMem())).Run();

    IConfigurationProvider config = ConfigurationProvider.Istance;

    IProductRepository prodotto = new ProductRepository();
    IOrderRepository order = new OrderRepository();

    bool continua = true;
    int scelta;

    while (continua)
    {
      Console.WriteLine($"-----Menu-----");
      Console.WriteLine($"1. Aggiungi un prodotto.");
      Console.WriteLine($"2. Visualizza tutti i prodotti.");
      Console.WriteLine($"3. Emetti verso tutti.");
      Console.WriteLine($"4. Esci.");
      scelta = Convert.ToInt32(Console.ReadLine());

      // switch (scelta)
      // {
      //   case 1:
      //     Console.WriteLine($"Inserisci il nome del prodotto: ");
      //     string name = Console.ReadLine();
      //     Console.WriteLine($"Inserisci il prezzo del prodotto: ");
      //     decimal price = decimal.Parse(Console.ReadLine());
      //     prodotto.Add(new Product(id++, name, new Money(price, config.Currency)));
      //     break;
      //   case 2:
      //     foreach (var p in prodotto)
      //     {
      //       Console.WriteLine(p);
      //     }
      //     break;
      //   case 3:
      //     foreach (var o in order)
      //     {
      //       Console.WriteLine(o);
      //     }
      //     break;
      //   case 4:
      //     continua = false;
      //     break;
      }
    }
  }
