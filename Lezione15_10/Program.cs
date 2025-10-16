// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.ComponentModel;
using Lezione15_10.Mattina;
using Lezione15_10.Mattina.Es_Creazione_Utente;
using Lezione15_10.Mattina.Es_Observer;
using Lezione15_10.Mattina.Es_ObserverDP;
using Lezione15_10.Pomeriggio.ES_Decorator;
using Lezione15_10.Pomeriggio.Esempio_Decorator;

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


    // GestoreCreazioneUtente gestore = GestoreCreazioneUtente.GetInstatnce();

    // IObserverDP moduloLog = new ModuloLog();
    // IObserverDP moduloMarketing = new ModuloMarketing();

    // gestore.Registra(moduloLog);
    // gestore.Registra(moduloMarketing);

    // bool continua = true;
    // int scelta;

    // while (continua)
    // {
    //   Console.WriteLine($"-----Menu Utente-----");
    //   Console.WriteLine($"1. Crea utente.");
    //   Console.WriteLine($"2. .");
    //   Console.WriteLine($"3. Esci.");
    //   scelta = Convert.ToInt32(Console.ReadLine());

    //   switch (scelta)
    //   {
    //     case 1:
    //       Console.WriteLine($"Inserisci il nome dell'utente: ");
    //       string? userName = Console.ReadLine();
    //       gestore.CreaUtente(userName);
    //       moduloLog.NotificaCreazione(userName);
    //       moduloMarketing.NotificaCreazione(userName);
    //       break;
    //     case 2:

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


    /// <summary>Esempio decorator</summary>


    // Oggetto di base
    // IComponentES component = new ConcreteComponent();
    // Console.WriteLine("Client: chiamata diretta al ConcreteComponent:");
    // component.Operation();

    // // Decoro con A
    // IComponentES decoratorA = new ConcreteDecoratorA(component);
    // Console.WriteLine("\nClient: ConcreteComponent decorato con A:");
    // decoratorA.Operation();

    // // Decoro con A poi B (catena di decorator)
    // IComponentES decoratorB = new ConcreteDecoratorB(decoratorA);
    // Console.WriteLine("\nClient: ConcreteComponent decorato con A e poi B:");
    // decoratorB.Operation();





    /// <summary>Esercizio decorator</summary>

    // Oggetto base con classe concreta (oggetto base senza decorazioni)
    // IBevanda bevanda = new Caffe();
    // bevanda.Descrizione();
    // bevanda.Costo();

    // //Decorazione base con concrete decorator ConLatte
    // IBevanda caffeLatte = new ConLatte(bevanda);
    // Console.WriteLine($"Descrizione latte: {caffeLatte.Descrizione()}");
    // Console.WriteLine($"Costo latte: {caffeLatte.Costo()}");

    // //Decorazione base con concrete decorator ConCioccolato
    // IBevanda caffeCioccolato = new ConCioccolato(bevanda);
    // Console.WriteLine($"Descrizione cioccolato: {caffeCioccolato.Descrizione()}");
    // Console.WriteLine($"Costo cioccolato: {caffeCioccolato.Costo()}");

    // //Decorazione base con concrete decorator ConPanna
    // IBevanda caffePanna = new ConPanna(bevanda);
    // Console.WriteLine($"Descrizione panna: {caffePanna.Descrizione()}");
    // Console.WriteLine($"Costo panna: {caffePanna.Costo()}");


    /// <summary>Esercizio decorator con factory</summary>


    ITorta torta = TortaFactory.CreaTortaBase("");

    bool continua = true;
    int scelta;

    while (continua)
    {
      Console.WriteLine($"-----Menu Torte-----");
      Console.WriteLine($"1. Crea Torta.");
      scelta = Convert.ToInt32(Console.ReadLine());

      switch (scelta)
      {
        case 1:
          Console.WriteLine($"Inserisci quale torta vuoi usare come base:\nCioccolato\nVaniglia\nFrutta");
          string? sceltaTortaBase = Console.ReadLine().ToLower();
          if (sceltaTortaBase == "cioccolato")
          {
            torta = new TortaCioccolato();
            Console.WriteLine($"Hai scleto come base la torta al cioccolato.");

          }
          else if (sceltaTortaBase == "vaniglia")
          {
            torta = TortaFactory.CreaTortaBase(sceltaTortaBase);
          }
          else if (sceltaTortaBase == "frutta")
          {
            torta = TortaFactory.CreaTortaBase(sceltaTortaBase);
          }
          else
          {
            Console.WriteLine("Tipo di torta non valido.");
          }
          continue;
      }

      bool aggiungiDecorazioni = true;

      while (aggiungiDecorazioni)
      {
        Console.WriteLine($"Vuoi aggiungere una decorazione? (s/n)");
        string? risposta = Console.ReadLine().ToLower();

        Console.WriteLine($"-----Menu Decorazioni-----");
        Console.WriteLine($"Text");
        
        
      }




    }
  }
}


