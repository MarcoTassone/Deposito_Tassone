// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Lezione20_10_Architetture.Dependency_Injection;

class Program
{
  public static void Main(string[] args)
  {
    // ILogger logger = new ConsoleLogger();
    // UserService userService = new UserService(logger);
    // userService.CreateUser("Alice");

    /// <summary>Esercizi DI</summary>

    // IGreeter greeter = new ConsoleGreeter();
    // var app = new GreetingService(greeter);
    // app.Start("Marco");

    // ILoggerGreet logger = new Logger();
    // var greetAndLog = new GreetingService(greeter, logger);
    // greetAndLog.GreetAndLog("Marco", "da console");

    // IPaymentGateway paymentGateway = null;

    // if (paymentGateway != null)
    // {
    //   var paga = new PaymentProcessor(paymentGateway);
    //   paga.Paga(20);
    // }

    // Console.WriteLine($"Scegli il metodo di pagamento desiderato:\nPaypal\nStripe");
    // string? scelta = Console.ReadLine().ToLower();

    // switch (scelta)
    // {
    //   case "paypal":
    //     paymentGateway = new PaypalGateway();
    //     break;
    //   case "stripe":
    //     paymentGateway = new StripeGateway();
    //     break;
    //   default:
    //     Console.WriteLine($"scelta non valida");
    //     break;
    // }

    AppConfig appConfig = AppConfig.Istance();

    ILoggerApp loggerApp = new LoggerService(appConfig);
    var ordine = new OrderService(loggerApp);

    bool continua = true;
    int scelta = 0;
    
    while (continua)
    {
      Console.WriteLine($"Menu ordine");
      Console.WriteLine($"1. Crea ordine");
      Console.WriteLine($"2. Esci");
      scelta = Convert.ToInt32(Console.ReadLine());

      switch (scelta)
      {
        case 1:
          Console.WriteLine($"Inserisci nome del prodotto: ");
          string? prodotto = Console.ReadLine();
          Console.WriteLine($"Inserisci il prezzo del prodotto: ");
          decimal prezzo = Convert.ToDecimal(Console.ReadLine());
          ordine.CreaOrdine(prodotto, prezzo);
          break;
        case 2:
          Console.WriteLine("Arrivederci!");
          continua = false;
          break;
      }
    }
  }
}