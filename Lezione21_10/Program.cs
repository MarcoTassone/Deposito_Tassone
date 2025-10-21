// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Lezione21_10.Mattina.Es_DI_e_Factory;
using Lezione21_10.Mattina.Es_Print;
using Lezione21_10.Mattina.Es_StorageService;
using Lezione21_10.Mattina.Esempio_DatabaseService;
using Lezione21_10.Pomeriggio.Es_DataExporter;
using Lezione21_10.Pomeriggio.Es_GiorniSettimana;
using Lezione21_10.Pomeriggio.Es_SMSNotifier;
using Lezione21_10.Pomeriggio.Es_TipoTransazione;
using Lezione21_10.Pomeriggio.Esempio_MethodInjection;
using Lezione21_10.Pomeriggio.Notifier_con_DI_e_Enum;

class Program
{
  public static void Main(string[] args)
  {

    #region Esempio_DatabaseService
    // var generator = new ReportGenerator();
    // generator.DatabaseService = new SqlDatabaseService();
    // generator.GenerateReport();
    #endregion

    #region Es_Print
    // var stampante = new Printer();
    // stampante.LoggerPrinter = new LoggerP();
    // stampante.Print();
    #endregion

    #region Es_StorageService
    // var save = new FileUploader();


    // Console.WriteLine($"Inserire nome del file: ");
    // string? nomeFile = Console.ReadLine();
    // Console.WriteLine($"Dove vuoi salvare il file? (disk/memory): ");
    // string? metodo = Console.ReadLine();

    // switch (metodo)
    // {
    //   case "disk":
    //     save.StorageService = new DiskService();
    //     save.Salvataggio(nomeFile, metodo);
    //     break;
    //   case "memory":
    //     save.StorageService = new MemoryService();
    //     save.Salvataggio(nomeFile, metodo);
    //     break;
    // }
    #endregion

    #region Es_DI_e_Factory

    // bool continua = true;
    // int scelta;

    // while (continua)
    // {
    //   Console.WriteLine($"--------Benvenuto!--------");
    //   Console.WriteLine($"1 - Crea libro fisico");
    //   Console.WriteLine($"2 - Crea libro digitale");
    //   Console.WriteLine($"3 - Inserisci quantità");

    //   Console.WriteLine($"4 - Esci");
    //   scelta = Convert.ToInt32(Console.ReadLine());

    //   switch (scelta)
    //   {
    //     case 1:

    //       break;
    //     case 2:
    //       break;
    //     case 3:
    //       break;
    //     case 4:
    //       continua = false;
    //       break;
    //   }
    // }
    #endregion

    #region Esempio_MethodInjection
    // INotifier notifier = new EmailNotifier();
    // var service = new NotificationService();
    // service.SendNotification("Luca", notifier);
    #endregion

    #region Es_SMSNotifier
    // INotifierSMS notifierSMS= new SMSNotifier();
    // ILoggerSMS loggerSMS = new LoggerSMS();
    // var service = new AlertService(loggerSMS);
    // service.SendAlert("Nuovo messaggio da...", notifierSMS);
    #endregion

    #region Es_DataExporter
    // var exporter = new DataExporter();
    // var data = new Data();

    // Console.WriteLine($"Inserire il nome del file da esportare: ");
    // string? file = Console.ReadLine();
    // Console.WriteLine($"Che tipo di file era?:\nJSON\nXML");
    // string? tipo = Console.ReadLine();

    // switch (tipo.ToLower())
    // {
    //   case "JSON":
    //     exporter.Export(data, new JsonExport());
    //     Console.WriteLine($"{file} esportato ");

    //     break;
    //   case "XML":
    //     exporter.Export(data, new XmlExport());
    //     break;
    // }
    #endregion

    #region Es_TipoTransazione
    // var transazione = new Transazione();

    // bool continua = true;
    // int scelta;

    // while (continua)
    // {
    //   Console.WriteLine($"--------Benvenuto!--------");
    //   Console.WriteLine($"Scegli il tipo di transazione da effettuare:");
    //   Console.WriteLine($"1 - Acquisto");
    //   Console.WriteLine($"2 - Rimborso");
    //   Console.WriteLine($"3 - Trasferimento");
    //   Console.WriteLine($"4 - Esci");
    //   scelta = Convert.ToInt32(Console.ReadLine());

    //   if (scelta == 4) break;

    //   switch (scelta)
    //   {
    //     case 1:
    //       transazione.tipoTransazione = Transazione.TipoTransazione.Acquisto;
    //       break;
    //     case 2:
    //       transazione.tipoTransazione = Transazione.TipoTransazione.Rimborso;
    //       break;
    //     case 3:
    //       transazione.tipoTransazione = Transazione.TipoTransazione.Trasferimento;
    //       break;
    //     default:
    //       Console.WriteLine("Scelta non valida.\n");
    //       continue;
    //   }

    //   Console.Write("Inserisci l'importo: ");
    //   decimal importo = decimal.Parse(Console.ReadLine()!);

    //   transazione.Transaction(importo);
    // }
    #endregion

    #region Es_GiorniSettimana

    // var giorni = new Giorni();

    // bool continua = true;
    // int scelta;

    // while (continua)
    // {
    //   Console.WriteLine($"--------Benvenuto!--------");
    //   Console.WriteLine($"Scegli il giorno della settimana:");
    //   Console.WriteLine($"1 - Lunedi'");
    //   Console.WriteLine($"2 - Martedi'");
    //   Console.WriteLine($"3 - Mercoledi'");
    //   Console.WriteLine($"4 - Giovedi'");
    //   Console.WriteLine($"5 - Venerdi'");
    //   Console.WriteLine($"6 - Sabato'");
    //   Console.WriteLine($"7 - Domenica'");
    //   Console.WriteLine($"8 - Esci");
    //   scelta = Convert.ToInt32(Console.ReadLine());

    //   if (scelta == 8) break;

    //   switch (scelta)
    //   {
    //     case 1:
    //       giorni.giornoSettimana = Giorni.GiornoSettimana.Lunedi;
    //       Console.WriteLine($"Il giorno della settimana corrente è Lunedì");

    //       break;
    //     case 2:
    //       giorni.giornoSettimana = Giorni.GiornoSettimana.Martedi;
    //       Console.WriteLine($"Il giorno della settimana corrente è Martedi");
    //       break;
    //     case 3:
    //       giorni.giornoSettimana = Giorni.GiornoSettimana.Mercoledi;
    //       Console.WriteLine($"Il giorno della settimana corrente è Mercoledi");
    //       break;
    //     case 4:
    //       giorni.giornoSettimana = Giorni.GiornoSettimana.Giovedi;
    //       Console.WriteLine($"Il giorno della settimana corrente è Giovedi");
    //       break;
    //     case 5:
    //       giorni.giornoSettimana = Giorni.GiornoSettimana.Venerdi;
    //       Console.WriteLine($"Il giorno della settimana corrente è Venerdi");
    //       break;
    //     case 6:
    //       giorni.giornoSettimana = Giorni.GiornoSettimana.Sabato;
    //       Console.WriteLine($"Il giorno della settimana corrente è Sabato");
    //       break;
    //     case 7:
    //       giorni.giornoSettimana = Giorni.GiornoSettimana.Domenica;
    //       Console.WriteLine($"Il giorno della settimana corrente è Domenica");
    //       break;
    //     default:
    //       Console.WriteLine("Scelta non valida.\n");
    //       break;
    //   }
    // }

    #endregion

    #region Notifier_con_DI_e_Enum
    while (true)
    {
      Console.WriteLine("\n===== SISTEMA DI NOTIFICHE =====");
      Console.WriteLine("1. Email");
      Console.WriteLine("2. SMS");
      Console.WriteLine("3. Push");
      Console.WriteLine("0. Esci");
      Console.Write("Scegli tipo notifica: ");

      string scelta = Console.ReadLine()!;
      if (scelta == "0") break;

      try
      {
        TipoNotifica tipo = scelta switch
        {
          "1" => TipoNotifica.Email,
          "2" => TipoNotifica.Sms,
          "3" => TipoNotifica.Push,
          _ => throw new Exception("Scelta non valida")
        };

        INotifierDIEnum notifier = NotifierFactory.CreaNotifier(tipo);
        var service = new MessaggioService(notifier);

        Console.Write("Inserisci il messaggio da inviare: ");
        string messaggio = Console.ReadLine()!;

        service.Invia(notifier, messaggio);
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Errore: {ex.Message}");
      }
    }

    Console.WriteLine("Programma terminato.");
  #endregion
  }
}

