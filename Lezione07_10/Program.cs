// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Net.WebSockets;
using Lezione07_10.Mattina;
using Lezione07_10.Pomeriggio.Ereditarietà;
using Lezione07_10.Pomeriggio.Ereditarietà.Es_Garage;
using Lezione07_10.Pomeriggio.Ereditarietà.Es_Scuola;

public class Program
{

  public static void Main(string[] args)
  {
    // Console.WriteLine($"Benvenuto nella libreria!");

    // Libro libro1 = new Libro("Il signore degli anelli", "JRR Tolkien", 1954);
    // Libro libro2 = new Libro("Il signore degli anelli", "JRR Tolkien", 1954);

    // Console.WriteLine($"ToString(): ");
    // Console.WriteLine(libro1.ToString());
    // Console.WriteLine();
    // Console.WriteLine($"Equals():");
    // Console.WriteLine(libro1.Equals(libro2));
    // Console.WriteLine();
    // Console.WriteLine($"GetHashCode(): ");
    // Console.WriteLine($"hashcode 1: {libro1.GetHashCode()}");
    // Console.WriteLine($"hashcode 2: {libro2.GetHashCode()}");
    // Console.WriteLine($"Sono uguali?: {libro1.GetHashCode() == libro2.GetHashCode()}");

    //Esercizio Macchina TUTTO SBAGLIATO

    // Utente utente = new Utente("Marco", 5);
    // Macchina macchina = new Macchina();
    // Macchina macchina1= new Macchina();
    // Macchina macchina2 = new Macchina();

    // Console.WriteLine($"Benvenuto! Come vuoi customizzare la tua macchina?");
    // do
    // {
    //   Console.WriteLine($"Motore: ");
    //   macchina.Motore = Console.ReadLine();
    //   Console.WriteLine($"Velocità macchina: ");
    //   macchina.VelocitaMacchina = Convert.ToInt32(Console.ReadLine());
    //   Console.WriteLine($"Sospensioni massime: ");
    //   macchina.SospensioniMax = Convert.ToInt32(Console.ReadLine());

    //   Console.WriteLine($"Motore: ");
    //   macchina1.Motore = Console.ReadLine();
    //   Console.WriteLine($"Velocità macchina: ");
    //   macchina1.VelocitaMacchina = Convert.ToInt32(Console.ReadLine());
    //   Console.WriteLine($"Sospensioni massime: ");
    //   macchina1.SospensioniMax = Convert.ToInt32(Console.ReadLine());

    //   Console.WriteLine($"Motore: ");
    //   macchina2.Motore = Console.ReadLine();
    //   Console.WriteLine($"Velocità macchina: ");
    //   macchina2.VelocitaMacchina = Convert.ToInt32(Console.ReadLine());
    //   Console.WriteLine($"Sospensioni massime: ");
    //   macchina2.SospensioniMax = Convert.ToInt32(Console.ReadLine());

    // } while (utente.Credito <= 0);

    // Console.WriteLine($"Ecco le tue modifiche: {macchina.Motore}, {macchina.VelocitaMacchina}, {macchina.SospensioniMax}");
    // Console.WriteLine($"Ecco le tue modifiche: {macchina1.Motore}, {macchina1.VelocitaMacchina}, {macchina1.SospensioniMax} ");
    // Console.WriteLine($"Ecco le tue modifiche: {macchina2.Motore}, {macchina2.VelocitaMacchina}, {macchina2.SospensioniMax}");


    /// <summary>Esercizio Film</summary>

    // Film film = new Film();
    // int scelta = 0;
    // bool continua = true;

    // Console.WriteLine($"Benvenuto nella libreria! Scegli un film da visualizzare: ");
    // while (continua)
    // {
    //   Console.WriteLine($"1. Crea film");
    //   Console.WriteLine($"2. Stampa film");
    //   Console.WriteLine($"3. Cerca film");
    //   Console.WriteLine($"4. Esci");
    //   scelta = int.Parse(Console.ReadLine());

    //   switch (scelta)
    //   {
    //     case 1:
    //       Console.WriteLine($"Inserisci il titolo del film: ");
    //       string titolo = Console.ReadLine();
    //       Console.WriteLine($"Inserisci il regista del film: ");
    //       string regista = Console.ReadLine();
    //       Console.WriteLine($"Inserisci l'anno del film: ");
    //       int anno = int.Parse(Console.ReadLine());
    //       Console.WriteLine($"Inserisci il genere del film: ");
    //       string genere = Console.ReadLine();
    //       film.aggiungiFilm(titolo, regista, anno, genere);
    //       break;
    //     case 2:
    //       film.Stampa();
    //       break;
    //     case 3:
    //       Console.WriteLine($"Inserisci il genere del film da cercare: ");
    //       string genereCercato = Console.ReadLine();
    //       film.cercaFilm(genereCercato);
    //       break;
    //     case 4:
    //       continua = false;
    //       Console.WriteLine($"Arrivederci!");
    //       break;
    //     default:
    //       Console.WriteLine("Scelta non valida");
    //       break;
    //   }
    // }

    /// <summary>Esempi di ereditarietà</summary>

    // Cane cane = new Cane();
    // cane.FaiVerso();
    // cane.Scondizola();
    // cane.Mangia();

    // Gatto gatto = new Gatto();
    // gatto.FaiVerso();

    // Elefante elefante = new Elefante();
    // elefante.ImpostaEta(10);

    /// <summary>Esercizio Garage</summary>

    // List<Veicolo> garage = new List<Veicolo>();
    // bool continua = true;
    // int scelta = 0;

    // while (continua)
    // {
    //   Console.WriteLine($"Menu garage: ");
    //   Console.WriteLine($"1. Inserisci un nuovo veicolo");
    //   Console.WriteLine($"2. Stampa tutti i veicoli");
    //   Console.WriteLine($"3. Esci");
    //   scelta = int.Parse(Console.ReadLine());

    //   switch (scelta)
    //   {
    //     case 1:
    //       Console.WriteLine($"Inserisci il tipo di veicolo (auto/moto): ");
    //       string tipo = Console.ReadLine();
    //       Console.WriteLine($"Inserisci la marca: ");
    //       string marca = Console.ReadLine();
    //       Console.WriteLine($"Inserisci il modello: ");
    //       string modello = Console.ReadLine();

    //       if (tipo == "auto")
    //       {
    //         Console.WriteLine("Numero porte: ");
    //         int porte = int.Parse(Console.ReadLine());
    //         garage.Add(new Auto(marca, modello, porte));
    //       }
    //       else if (tipo == "moto")
    //       {
    //         Console.WriteLine($"Tipo di manubrio: ");
    //         string tipoManubrio = Console.ReadLine();
    //         garage.Add(new Moto(marca, modello, tipoManubrio));
    //       }
    //       else
    //       {
    //         Console.WriteLine($"Tipo non valido!");
    //       }
    //       break;
    //     case 2:
    //       Console.WriteLine($"Veicoli nel garage: \n");
    //       foreach (Veicolo v in garage)
    //       {
    //         Console.WriteLine(v);
    //       }
    //       break;
    //     case 3:
    //       continua = false;
    //       Console.WriteLine($"Arrivederci!");
    //       break;
    //     default:
    //       Console.WriteLine($"Scelta non valida!");
    //       break;
    //   }
    // }

    List<Corso> corsi = new List<Corso>();
    Corso studenti = new Corso(" ", " ", 0, new List<string>());

    bool continua = true;
    int scelta = 0;

    while (continua)
    {
      Console.WriteLine($"Menu corsi: ");
      Console.WriteLine($"1. Aggiungi un corso di Musica");
      Console.WriteLine($"2. Aggiungi un corso di Pittura");
      Console.WriteLine($"3. Aggiungi un corso di Danza");
      Console.WriteLine($"4. Aggiungi uno studente a un corso");
      Console.WriteLine($"5. Visualizza tutti i corsi");
      Console.WriteLine($"6. Cerca corsi per nome docente");
      Console.WriteLine($"7. Esegui un metodo speciale");
      Console.WriteLine($"8. Esci");
      scelta = int.Parse(Console.ReadLine());

      switch (scelta)
      {
        case 1:
          Console.WriteLine($"Inserisci il nome del corso: ");
          string? nome = Console.ReadLine();
          Console.WriteLine($"Inserisci il nome del docente: ");
          string? docente = Console.ReadLine();
          Console.WriteLine($"Inserisci la durata del corso: ");
          int durata = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine($"Inserisci lo strumento da suonare: ");
          string? strumento = Console.ReadLine();

          corsi.Add(new CorsoMusica(nome, docente, durata, new List<string>(), strumento));
          break;

        case 2:
          Console.WriteLine($"Inserisci il nome del corso: ");
          string? nome2 = Console.ReadLine();
          Console.WriteLine($"Inserisci il nome del docente: ");
          string? docente2 = Console.ReadLine();
          Console.WriteLine($"Inserisci la durata del corso: ");
          int durata2 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine($"Inserisci la tecnica da utilizzare: ");
          string? tecnica = Console.ReadLine();

          corsi.Add(new CorsoPittura(nome2, docente2, durata2, new List<string>(), tecnica));
          break;

        case 3:
          Console.WriteLine($"Inserisci il nome del corso: ");
          string? nome3 = Console.ReadLine();
          Console.WriteLine($"Inserisci il nome del docente: ");
          string? docente3 = Console.ReadLine();
          Console.WriteLine($"Inserisci la durata del corso: ");
          int durata3 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine($"Inserisci lo stile da utilizzare: ");
          string? stile = Console.ReadLine();

          corsi.Add(new CorsoDanza(nome3, docente3, durata3, new List<string>(), stile));
          break;
        case 4:
          string nomeStudente = Console.ReadLine();
          studenti.AggiungiStudente(nomeStudente);
          break;
      }
    }
  }
}