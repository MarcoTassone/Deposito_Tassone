// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Net.WebSockets;
using Lezione07_10.Mattina;
using Lezione07_10.Pomeriggio.Ereditarietà;
using Lezione07_10.Pomeriggio.Ereditarietà.Es_Garage;

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

    // Film film1 = new Film("Il signore degli anelli e la compagnia dell'anello", "Peter Jackson", 2001, "Fantasy");
    // Film film2 = new Film("Harry Potter e la pietra filosofale", "Chris Columbus", 2001, "Fantasy");
    // Film film3 = new Film("Scream", "Wes Craven", 1996, "Horror");
    // Film film4 = new Film("The Shining", "Stanley Kubrick", 1980, "Horror");
    // Film film5 = new Film("6-Headed Shark Attack", "Mark Atkins", 2018, "Horror");

    // List<Film> film = new List<Film> { film1, film2, film3, film4, film5 };
    // int scelta = 0;

    // Console.WriteLine($"Benvenuto nella libreria! Scegli un film da visualizzare: ");
    // while (true)
    // {

    //   Console.WriteLine($"1. {film1.ToString()}");
    //   Console.WriteLine($"2. {film2.ToString()}");
    //   Console.WriteLine($"3. {film3.ToString()}");
    //   Console.WriteLine($"4. {film4.ToString()}");
    //   Console.WriteLine($"5. {film5.ToString()}");
    //   scelta = int.Parse(Console.ReadLine());

    //   switch (scelta)
    //   {
    //     case 1:
    //       film1.Stampa();
    //       break;
    //     case 2:
    //       film2.Stampa();
    //       break;
    //     case 3:
    //       film3.Stampa();
    //       break;
    //     case 4:
    //       film4.Stampa();
    //       break;
    //     case 5:
    //       film5.Stampa();
    //       break;
    //     case 6:
    //       Console.WriteLine($"Inserisci il genere del film da cercare: ");
    //       string genere = Console.ReadLine();
    //       film1.cercaFilm(genere);
    //       film2.cercaFilm(genere);
    //       film3.cercaFilm(genere);
    //       film4.cercaFilm(genere);
    //       film5.cercaFilm(genere);
    //       break;
    //     default:
    //       Console.WriteLine("Scelta non valida");
    //       break;
    //   }
    // }

    // Cane cane = new Cane();
    // cane.FaiVerso();
    // cane.Scondizola();
    // cane.Mangia();

    // Gatto gatto = new Gatto();
    // gatto.FaiVerso();

    // Elefante elefante = new Elefante();
    // elefante.ImpostaEta(10);

    List<Veicolo> garage = new List<Veicolo>();
    bool continua = true;
    int scelta = 0;

    while (continua)
    {
      Console.WriteLine($"Menu garage: ");
      Console.WriteLine($"1. Inserisci un nuovo veicolo");
      Console.WriteLine($"2. Stampa tutti i veicoli");
      Console.WriteLine($"3. Esci");
      scelta = int.Parse(Console.ReadLine());

      switch (scelta)
      {
        case 1:
          Console.WriteLine($"Inserisci il tipo di veicolo (auto/moto): ");
          string tipo = Console.ReadLine();

          Console.WriteLine($"Inserisci la marca: ");
          string marca = Console.ReadLine();

          Console.WriteLine($"Inserisci il modello: ");
          string modello = Console.ReadLine();

          if (tipo == "auto")
          {
            Console.WriteLine("Numero porte: ");
            int porte = int.Parse(Console.ReadLine());
            garage.Add(new Auto(marca, modello, porte));
          }
          else if (tipo == "moto")
          {
            Console.WriteLine($"Tipo di manubrio: ");
            string tipoManubrio = Console.ReadLine();
            garage.Add(new Moto(marca, modello, tipoManubrio));
          }
          else
          {
            Console.WriteLine($"Tipo non valido!");

          }
          break;
        case 2:
          Console.WriteLine($"Veicoli nel garage: \n");
          foreach (Veicolo v in garage)
          {
            Console.WriteLine(v.ToString());
          }
          break;
        case 3:
          continua = false;
          Console.WriteLine($"Arrivederci!");
          break;
        default:
          Console.WriteLine($"Scelta non valida!");
          break;
      }
    }
  }
}