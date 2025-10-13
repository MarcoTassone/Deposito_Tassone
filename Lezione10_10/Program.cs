// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using Lezione10_10.Pomeriggio;
using Lezione10_10.Pomeriggio.DispositivoElettrico;
using Lezione10_10.Pomeriggio.Es_Corsi;
using Lezione10_10.Pomeriggio.Interfaccia_Pagamento;

class Program
{
  public static void Main(string[] args)
  {
    // Veicolo miaAuto = new Auto();
    // miaAuto.Avvia();

    // IVeicoloElettrico mioScooter = new ScooterElettrico();
    // mioScooter.Ricarica();


    /// <summary>Esercizio abstract</summary>

    //   List<DispositivoElettronico> dispositivi = new List<DispositivoElettronico>();

    //   bool continua = true;
    //   int scelta = 0;

    //   while (continua)
    //   {
    //     Console.WriteLine("1. Aggiungi un dispositivo elettronico.");
    //     Console.WriteLine("2. Mostra informazioni dispositivo.");
    //     Console.WriteLine("3. Accendi dispositivo.");
    //     Console.WriteLine("4. Spegni dispositivo.");
    //     Console.WriteLine("5. Esci.");
    //     scelta = Convert.ToInt32(Console.ReadLine());

    //     switch (scelta)
    //     {
    //       case 1:
    //         Console.WriteLine($"Quale dispositivo vuoi inserire?\n 1.Computer\n 2.Stampante");
    //         int sceltaDispositivo = Convert.ToInt32(Console.ReadLine());
    //         if (sceltaDispositivo == 1)
    //         {
    //           Console.WriteLine($"Inserisci il modello del computer");
    //           string? modelloComputer = Console.ReadLine();
    //           Computer computer = new Computer(modelloComputer);
    //           dispositivi.Add(computer);
    //         }
    //         else if (sceltaDispositivo == 2)
    //         {
    //           Console.WriteLine($"Inserisci il modello della stampante");
    //           string? modelloStampante = Console.ReadLine();
    //           Stampante stampante = new Stampante(modelloStampante);
    //           dispositivi.Add(stampante);
    //         }
    //         break;
    //       case 2:
    //         Console.WriteLine($"Di quale dispositivo vuoi mostrare le informazioni?\n 1.Computer\n 2.Stampante");
    //         sceltaDispositivo = Convert.ToInt32(Console.ReadLine());
    //         MostraInfoDispositivo(dispositivi[sceltaDispositivo - 1]);
    //         break;
    //       case 3:
    //         Console.WriteLine($"Quale dispositivo vuoi accendere?\n 1.Computer\n 2.Stampante");
    //         sceltaDispositivo = Convert.ToInt32(Console.ReadLine());
    //         AccendiDispositivo(dispositivi[sceltaDispositivo - 1]);
    //         break;
    //       case 4:
    //         Console.WriteLine($"Quale dispositivo vuoi spegnere?\n 1.Computer\n 2.Stampante");
    //         sceltaDispositivo = Convert.ToInt32(Console.ReadLine());
    //         SpegniDispositivo(dispositivi[sceltaDispositivo - 1]);
    //         break;
    //       case 5:
    //         continua = false;
    //         Console.WriteLine($"Uscita dal programma.");
    //         break;
    //     }
    //   }
    // }

    // static void MostraInfoDispositivo(DispositivoElettronico d)
    // {
    //   d.MostraInfo();
    // }

    // static void AccendiDispositivo(DispositivoElettronico d)
    // {
    //   d.Accendi();
    // }

    // static void SpegniDispositivo(DispositivoElettronico d)
    // {
    //   d.Spegni();
    // }



    /// <summary>Esercizio abstract pagamento</summary>


    // List<IPagamento> pagamenti = new List<IPagamento>();

    // bool continua = true;
    // int scelta = 0;

    // while (continua)
    // {
    //   Console.WriteLine("1. Scegli il metodo di pagamento desiderato e inserisci l'importo.");
    //   Console.WriteLine("2. Mostra l'ultimo metodo di pagamento inserito.");
    //   Console.WriteLine("3. Esci.");
    //   scelta = Convert.ToInt32(Console.ReadLine());

    //   switch (scelta)
    //   {
    //     case 1:
    //       Console.WriteLine($"Con quale metodo di pagamento desideri pagare l'importo? \n 1.Carta\n 2.Contanti\n 3.PayPal");
    //       int sceltaMetodo = Convert.ToInt32(Console.ReadLine());
    //       Console.WriteLine($"Inserisci l'importo da pagare: ");
    //       decimal importo = Convert.ToDecimal(Console.ReadLine());
    //       if (sceltaMetodo == 1)
    //       {
    //         Console.WriteLine($"Inserire il circuito della carta: ");
    //         string? circuito = Console.ReadLine();
    //         pagamenti.Add(new PagamentoCarta(circuito));
    //         pagamenti[pagamenti.Count - 1].EseguiPagamento(importo);
    //       }
    //       else if (sceltaMetodo == 2)
    //       {
    //         pagamenti.Add(new PagamentoContanti());
    //         pagamenti[pagamenti.Count - 1].EseguiPagamento(importo);
    //       }
    //       else if (sceltaMetodo == 3)
    //       {
    //         Console.WriteLine($"Inserire la mail dell'utente: ");
    //         string? emailUtente = Console.ReadLine();
    //         pagamenti.Add(new PagamentoPayPal(emailUtente));
    //         pagamenti[pagamenti.Count - 1].EseguiPagamento(importo);
    //       }
    //       break;
    //     case 2:
    //       MostraMetodoPagamento(pagamenti[pagamenti.Count - 1]);
    //       break;
    //     case 3:
    //       continua = false;
    //       Console.WriteLine($"Uscita dal programma.");
    //       break;
    //   }
    // }


    List<Corso> corsi = new List<Corso>();

    bool continua = true;
    int scelta = 0;

    while (continua)
    {
      Console.WriteLine("1. Inserisci un nuovo corso.");
      Console.WriteLine("2. Mostra i dettagli di un corso.");
      Console.WriteLine("3. Esci.");
      scelta = Convert.ToInt32(Console.ReadLine());

      switch (scelta)
      {
        case 1:
          Console.WriteLine($"Che tipo di corso desideri inserire?\n 1.Corso in presenza\n 2.Corso online");
          int sceltaCorso = Convert.ToInt32(Console.ReadLine());

          if (sceltaCorso == 1)
          {
            Console.WriteLine($"Inserire il titolo del corso: ");
            string? titolo = Console.ReadLine();
            Console.WriteLine($"Inserire la durata del corso: ");
            int durataOre = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Inserire il numero di posti del corso: ");
            int numeroPosti = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Inserire l'aula del corso: ");
            string? aula = Console.ReadLine();
            corsi.Add(new CorsoInPresenza(titolo, durataOre, numeroPosti, aula));
          }
          else if (sceltaCorso == 2)
          {
            Console.WriteLine($"Inserire il titolo del corso: ");
            string? titolo = Console.ReadLine();
            Console.WriteLine($"Inserire la durata del corso: ");
            int durataOre = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Inserire la piattaforma del corso: ");
            string? piattaforma = Console.ReadLine();
            Console.WriteLine($"Inserire il link di accesso del corso: ");
            string? linkAccesso = Console.ReadLine();
            corsi.Add(new CorsoOnline(titolo, durataOre, piattaforma, linkAccesso));
          }
          break;
        case 2:
          StampaDettagliCorso(corsi[corsi.Count - 1]);
          break;
        case 3:
          continua = false;
          Console.WriteLine($"Uscita dal programma.");
          break;
      }
    }
  }

    /// <summary>metodo usato per l'esercizio pagamento</summary>
    // static void MostraMetodoPagamento(IPagamento p)
    // {
    //   p.MostraPagamento();
    // }
    

    /// <summary>Metodo stama dettagli dei corsi</summary>
    /// 
    static void StampaDettagliCorso(Corso c)
    {
      c.StampaDettagli();
    }
}