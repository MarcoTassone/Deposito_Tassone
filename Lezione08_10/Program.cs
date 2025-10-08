// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Lezione08_10.Mattina;
using Lezione08_10.Mattina.Esempi_Incapsulamento;
using Lezione08_10.Mattina.PrenotazioneViaggio;

public class Program
{
  public static void Main(string[] args)
  {
    /// <summary>Esercizio VoloAereo</summary>

    // VoloAereo volo = new VoloAereo("ABC123");
    // volo.VisualizzaStato();
    // volo.EffettuaPrenotazione(5);
    // volo.VisualizzaStato();
    // volo.AnnullaPrenotazione(3);
    // volo.VisualizzaStato();


    /// <summary>Esempio Incapsulamento</summary>

    // ContoBancario conto = new ContoBancario();

    // conto.Saldo = 100.40;
    // Console.WriteLine(conto.Saldo);
    // conto.Saldo = -5.50;
    // Console.WriteLine(conto.Saldo);


    /// <summary>Esercizio PrenotazioneViaggio Senza Extra</summary>

    // PrenotazioneViaggio prenotazioneViaggio = new PrenotazioneViaggio();

    // Console.WriteLine($"Inserisci una destinazione: ");
    // prenotazioneViaggio.Destinazione = Console.ReadLine();
    // prenotazioneViaggio.PrenotaPosti(5);
    // prenotazioneViaggio.VisualizzaStato();
    // prenotazioneViaggio.AnnullaPrenotazione(3);
    // prenotazioneViaggio.VisualizzaStato();

    // bool continua = true;
    // int scelta = 0;

    // while (continua)
    // {
    //   prenotazioneViaggio.VisualizzaStato();
    //   Console.WriteLine($"1. Inserisci una destinazione: ");
    //   Console.WriteLine($"2. Prenota posti");
    //   Console.WriteLine($"3. Annulla prenotazione");
    //   Console.WriteLine($"4. Visualizza prenotazione:");
    //   Console.WriteLine($"5. Esci");
    //   scelta = int.Parse(Console.ReadLine());
    //   switch (scelta)
    //   {
    //     case 1:
    //       Console.WriteLine($"Inserisci una destinazione: ");
    //       prenotazioneViaggio.Destinazione = Console.ReadLine();
    //       break;
    //     case 2:
    //       Console.WriteLine($"Inserisci il numero di posti da prenotare: ");
    //       prenotazioneViaggio.PrenotaPosti(int.Parse(Console.ReadLine()));
    //       break;
    //     case 3:
    //       Console.WriteLine($"Inserisci il numero di posti da annullare: ");
    //       prenotazioneViaggio.AnnullaPrenotazione(int.Parse(Console.ReadLine()));
    //       break;
    //     case 4:
    //       prenotazioneViaggio.VisualizzaStato();
    //       break;
    //     case 5:
    //       continua = false;
    //       Console.WriteLine($"Arrivederci!");
    //       break;
    //     default:
    //       Console.WriteLine($"Scelta non valida!");
    //       break;
    //   }
    // }


    
  }
}