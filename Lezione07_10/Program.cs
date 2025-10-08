// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Net.WebSockets;
using System.Runtime.InteropServices;
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

    //Esercizio Macchina

    // bool continua = true;
    // int scelta = 0;

    // Console.WriteLine($"Benvenuto! Configura l'utente: ");

    // for (int i = 0; i <= 3; i++)
    // {
    //   Console.WriteLine($"Inserisci il tuo nome: ");
    //   string nome = Console.ReadLine();
    //   Console.WriteLine($"Inserisci i tuoi crediti iniziali (0-4): ");
    //   int crediti = Convert.ToInt32(Console.ReadLine());
    //   Utente utente = new Utente(nome, crediti);
    //   Console.WriteLine($"Inserisci il motore della macchina: ");
    //   string motore = Console.ReadLine();
    //   Console.WriteLine($"Inserisci la velocita della macchina: ");
    //   float velocitaMacchina = float.Parse(Console.ReadLine());
    //   Console.WriteLine($"Inserisci il numero di sospensioni della macchina: ");
    //   int sospensioniMax = int.Parse(Console.ReadLine());
    //   Macchina macchina = new Macchina(motore, velocitaMacchina, sospensioniMax);
    //   while (utente.Credito > 0)
    //   {
    //     Console.WriteLine($"Scegli una modifica: ");
    //     Console.WriteLine($"1 - Cambia tipo di motore");
    //     Console.WriteLine($"2 - Aumenta la velocita");
    //     Console.WriteLine($"3 - Aumenta il numero di sospensioni");
    //     Console.WriteLine($"4 - Esci");
    //     scelta = int.Parse(Console.ReadLine());

    //     switch (scelta)
    //     {
    //       case 1:
    //         Console.WriteLine($"Inserisci il nuovo motore: ");
    //         string nuovoMotore = Console.ReadLine();
    //         macchina.Motore = nuovoMotore;
    //         macchina.NrModifiche++;
    //         utente.Credito--;
    //         break;
    //       case 2:
    //         macchina.VelocitaMacchina += 10f;
    //         Console.WriteLine($"Velocità aumentata!");
    //         macchina.NrModifiche++;
    //         utente.Credito--;
    //         break;
    //       case 3:
    //         macchina.SospensioniMax += 1;
    //         Console.WriteLine($"Sospensioni aumentate!");
    //         macchina.NrModifiche++;
    //         utente.Credito--;
    //         macchina.SospensioniMax = Convert.ToInt32(Console.ReadLine());
    //         break;
    //       case 4:
    //         Console.WriteLine($"Arrivederci! Hai acquistato {macchina.NrModifiche} modifica!");
    //         macchina.NrModifiche = Convert.ToInt32(Console.ReadLine());
    //         break;
    //       default:
    //         continua = false;
    //         Console.WriteLine($"Scelta non valida!");
    //         break;
    //     }
    //   }

    //   macchina.Stampa(utente.Nome);
    // }




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



    /// <summary>Esercizio Corsi</summary>

    // List<Corso> corsi = new List<Corso>();

    // bool continua = true;
    // int scelta = 0;

    // while (continua)
    // {
    //   Console.WriteLine($"Menu corsi: ");
    //   Console.WriteLine($"1. Aggiungi un corso di Musica");
    //   Console.WriteLine($"2. Aggiungi un corso di Pittura");
    //   Console.WriteLine($"3. Aggiungi un corso di Danza");
    //   Console.WriteLine($"4. Aggiungi uno studente a un corso");
    //   Console.WriteLine($"5. Visualizza tutti i corsi");
    //   Console.WriteLine($"6. Cerca corsi per nome docente");
    //   Console.WriteLine($"7. Esegui un metodo speciale");
    //   Console.WriteLine($"8. Esci");
    //   scelta = int.Parse(Console.ReadLine());

    //   switch (scelta)
    //   {
    //     case 1:
    //       Console.WriteLine($"Inserisci il nome del corso: ");
    //       string? nome = Console.ReadLine();
    //       Console.WriteLine($"Inserisci il nome del docente: ");
    //       string? docente = Console.ReadLine();
    //       Console.WriteLine($"Inserisci la durata del corso: ");
    //       int durata = Convert.ToInt32(Console.ReadLine());
    //       Console.WriteLine($"Inserisci lo strumento da suonare: ");
    //       string? strumento = Console.ReadLine();

    //       corsi.Add(new CorsoMusica(nome, docente, durata, strumento));
    //       break;

    //     case 2:
    //       Console.WriteLine($"Inserisci il nome del corso: ");
    //       string? nome2 = Console.ReadLine();
    //       Console.WriteLine($"Inserisci il nome del docente: ");
    //       string? docente2 = Console.ReadLine();
    //       Console.WriteLine($"Inserisci la durata del corso: ");
    //       int durata2 = Convert.ToInt32(Console.ReadLine());
    //       Console.WriteLine($"Inserisci la tecnica da utilizzare: ");
    //       string? tecnica = Console.ReadLine();

    //       corsi.Add(new CorsoPittura(nome2, docente2, durata2, tecnica));
    //       break;

    //     case 3:
    //       Console.WriteLine($"Inserisci il nome del corso: ");
    //       string? nome3 = Console.ReadLine();
    //       Console.WriteLine($"Inserisci il nome del docente: ");
    //       string? docente3 = Console.ReadLine();
    //       Console.WriteLine($"Inserisci la durata del corso: ");
    //       int durata3 = Convert.ToInt32(Console.ReadLine());
    //       Console.WriteLine($"Inserisci lo stile da utilizzare: ");
    //       string? stile = Console.ReadLine();

    //       corsi.Add(new CorsoDanza(nome3, docente3, durata3, stile));
    //       break;
    //     case 4:
    //       for (int i = 0; i < corsi.Count; i++)
    //       {
    //         Console.WriteLine($"{i}. {corsi[i].NomeCorso}");
    //       }
    //       Console.WriteLine($"Inserisci il nome dello studente:");
    //       string? nomeStudente = Console.ReadLine();
    //       Console.WriteLine($"Indice del corso: ");
    //       int indice = Convert.ToInt32(Console.ReadLine());
    //       corsi[indice].AggiungiStudente(nomeStudente);
    //       break;
    //     case 5:
    //       foreach (Corso corso in corsi)
    //       {
    //         Console.WriteLine(corso.ToString());
    //       }
    //       break;
    //     case 6:
    //       Console.WriteLine($"Di quale docente vuoi visualizzare i corsi? ");
    //       string? ricercaDocente = Console.ReadLine();
    //       foreach (Corso d in corsi)
    //       {
    //         if (d.Docente.Equals(ricercaDocente))
    //         {
    //           Console.WriteLine(d);
    //         }
    //       }
    //       break;
    //     case 7:
    //       Console.WriteLine($"Di quale corso vuoi eseguire il metodo speciale? ");
    //       string? ricerca2 = Console.ReadLine();
    //       for (int i = 0; i < corsi.Count; i++)
    //       {
    //         Console.WriteLine($"{i}. {corsi[i].NomeCorso}");
    //       }
    //       Console.WriteLine($"Indice del corso: ");
    //       int indice2 = Convert.ToInt32(Console.ReadLine());
    //       corsi[indice2].MetodoSpeciale();
    //       break;
    //     case 8:
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