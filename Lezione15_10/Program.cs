// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Lezione15_10.Mattina;
using Lezione15_10.Mattina.Es_Creazione_Utente;
using Lezione15_10.Mattina.Es_Observer;
using Lezione15_10.Mattina.Es_ObserverDP;

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

    // var subject = new CentroMeteo();
    // var observer = new CentroMeteo();


    // var displayConsole = new DisplayConsole();
    // var displayMobile = new DisplayMobile();

    // bool continua = true;
    // bool continuaObserver = true;
    // int scelta;
    // int sceltaObserver;


    /// <summary>Prova con extra non finito</summary>
    // while (continuaObserver)
    // {
    //   Console.WriteLine($"-----Menu Observer-----");
    //   Console.WriteLine($"1. Aggiungi observer.");
    //   Console.WriteLine($"2. Rimuovi observer.");
    //   Console.WriteLine($"3. Esci.");
    //   sceltaObserver = Convert.ToInt32(Console.ReadLine());

    //   switch (sceltaObserver)
    //   {
    //     case 1:
    //       Console.WriteLine($"Inserisci il nome dell'observer: ");
    //       string? observerName = Console.ReadLine();
    //       subject.;
    //       break;
    //     case 2:
    //       Console.WriteLine($"Inserisci il nome dell'observer da rimuovere: ");
    //       observerName = Console.ReadLine();
    //       subject.Rimuovi(observerName);
    //       break;
    //     case 3:
    //       continuaObserver = false;
    //       break;
    //     default:
    //       Console.WriteLine($"Scelta non valida.");
    //       break;
    //   }
    // }

    // while (continua)
    // {
    //   Console.WriteLine($"-----Menu Meteo-----");
    //   Console.WriteLine($"1. Inserisci meteo.");
    //   Console.WriteLine($"2. Aggiorna observer.");
    //   Console.WriteLine($"3. Esci.");
    //   scelta = Convert.ToInt32(Console.ReadLine());

    //   switch (scelta)
    //   {
    //     case 1:
    //       Console.WriteLine($"Inserisci il meteo: ");
    //       string? meteo = Console.ReadLine();
    //       displayConsole.Aggiorna(meteo);
    //       displayMobile.Aggiorna(meteo);
    //       break;
    //     case 2:
    //       Console.WriteLine($"Aggiorna meteo.");
    //       string? meteoAggiornato = Console.ReadLine();
    //       subject.AggiornaMeteo(meteoAggiornato);
    //       displayConsole.Aggiorna(meteoAggiornato);
    //       displayMobile.Aggiorna(meteoAggiornato);
    //       break;
    //     case 3:
    //       Console.WriteLine($"Arrivederci!");
    //       continua = false;
    //       break;
    //     default:
    //       Console.WriteLine($"Scelta non valida.");
    //       break;
    //   }
    // }


    /// <summary>Esercizio observer + singleton</summary>


    // NewsAgency newsAgency = NewsAgency.GetInstance();

    // INewsSubscriber mobileSubcriber = new MobileApp();
    // INewsSubscriber emailSubcriber = new EmailClient();

    // newsAgency.AddSubscriber(mobileSubcriber);
    // newsAgency.AddSubscriber(emailSubcriber);

    // Console.WriteLine($"Inserisci il titolo della notizia: ");
    // string? title = Console.ReadLine();
    // newsAgency.Notify(title);
    // Console.WriteLine($"Ci sono altre notizie? (s/n)");
    // string? risposta = Console.ReadLine().ToLower();
    // if (risposta == "n")
    // {
    //   Console.WriteLine($"Notizie terminate.");
    // }
    // else
    // {
    //   Console.WriteLine($"Inserisci nuova notizia: ");
    //   string? nuoveNotizie = Console.ReadLine();
    //   newsAgency.Notify(nuoveNotizie);
    // }



    /// <summary>Esercizio con 2 pattern (potrebbero essere 3)</summary>


    GestoreCreazioneUtente gestore = GestoreCreazioneUtente.GetInstatnce();

    IObserverDP moduloLog = new ModuloLog();
    IObserverDP moduloMarketing = new ModuloMarketing();

    gestore.Registra(moduloLog);
    gestore.Registra(moduloMarketing);

    bool continua = true;
    int scelta;

    while (continua)
    {
      Console.WriteLine($"-----Menu Utente-----");
      Console.WriteLine($"1. Crea utente.");
      Console.WriteLine($"2. .");
      Console.WriteLine($"3. Esci.");
      scelta = Convert.ToInt32(Console.ReadLine());

      switch (scelta)
      {
        case 1:
          Console.WriteLine($"Inserisci il nome dell'utente: ");
          string? userName = Console.ReadLine();
          gestore.CreaUtente(userName);
          moduloLog.NotificaCreazione(userName);
          moduloMarketing.NotificaCreazione(userName);
          break;
        case 2:
          
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

