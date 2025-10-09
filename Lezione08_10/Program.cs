// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Lezione08_10.Mattina;
using Lezione08_10.Mattina.Esempi_Incapsulamento;
using Lezione08_10.Mattina.PrenotazioneViaggio;
using Lezione08_10.Pomeriggio.Es_Soldato;
using Lezione08_10.Pomeriggio.Es_VeicoloRipara;
using Lezione08_10.Pomeriggio.Esempi_Polimorfismo;

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


    /// <summary>Esercizio Soldato</summary>

    // List<Soldato> soldato = new List<Soldato>();

    // bool continua = true;
    // int scelta = 0;

    // while (continua)
    // {
    //   Console.WriteLine($"------Menu esercito------");
    //   Console.WriteLine($"1. Aggiungi un nuovo fante. ");
    //   Console.WriteLine($"2. Aggiungi un nuovo artigliere.");
    //   Console.WriteLine($"3. Visualizza tutti i soldati");
    //   Console.WriteLine($"4. Esci");
    //   scelta = int.Parse(Console.ReadLine());

    //   switch (scelta)
    //   {
    //     case 1:
    //       Console.WriteLine($"Inserisci nome del soldato: ");
    //       string? nomeFante = Console.ReadLine();
    //       Console.WriteLine($"Inserisci grado del soldato:");
    //       string? gradoFante = Console.ReadLine();
    //       Console.WriteLine($"Inserisci anni di servizio del fante: ");
    //       int anniServizioFante = Convert.ToInt32(Console.ReadLine());
    //       Console.WriteLine($"Inserisci l'arma del fante: ");
    //       string? armaFante = Console.ReadLine();
    //       soldato.Add(new Fante(nomeFante, gradoFante, anniServizioFante, armaFante));
    //       break;
    //     case 2:
    //       Console.WriteLine($"Inserisci il nome dell'artigliere: ");
    //       string? nomeArtigliere = Console.ReadLine();
    //       Console.WriteLine($"Inserisci il grado dell'artigliere: ");
    //       string? gradoArtigliere = Console.ReadLine();
    //       Console.WriteLine($"Inserisci anni di servizio dell'artigliere: ");
    //       int anniServizioArtigliere = Convert.ToInt32(Console.ReadLine());
    //       Console.WriteLine($"Inserisci il calibro gestito dall'artigliere: ");
    //       int calibroArtigliere = Convert.ToInt32(Console.ReadLine());
    //       soldato.Add(new Artigliere(nomeArtigliere, gradoArtigliere, anniServizioArtigliere, calibroArtigliere));
    //       break;
    //     case 3:
    //       foreach (Soldato s in soldato)
    //       {
    //         Console.WriteLine($"{s.Descrizione()}");
    //       }
    //       break;
    //     case 4:
    //       continua = false;
    //       Console.WriteLine($"Arriverderci!");
    //       break;
    //     default:
    //       Console.WriteLine($"Scelta non valida!");
    //       break;
    //   }
    // }


    /// <summary>esempio polimorfismo</summary>


    // List<Forma> forme = new List<Forma>();

    // new Rettangolo { Base = 4, Altezza = 5 };
    // new Cerchio { Raggio = 3 };


    // foreach (Forma f in forme)
    // {
    //   Console.WriteLine("Area: " + f.CalcolaArea());
    // }


    /// <summary>Esercizio ripara veicolo</summary>

    // List<Veicolo> veicoli = new List<Veicolo>
    // {
    //   new Auto("sv23234mv"),
    //   new Moto("mb234ct"),
    //   new Camion("sk854la")
    // };

    // foreach (var v in veicoli)
    // {
    //   Console.WriteLine($"{v.Targa} - {v.Ripara()}");
    // }


  }
}