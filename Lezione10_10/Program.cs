// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using Lezione10_10.Pomeriggio;
using Lezione10_10.Pomeriggio.DispositivoElettrico;

class Program
{
  public static void Main(string[] args)
  {
    // Veicolo miaAuto = new Auto();
    // miaAuto.Avvia();

    // IVeicoloElettrico mioScooter = new ScooterElettrico();
    // mioScooter.Ricarica();


    /// <summary>Esercizio abstract</summary>

    List<DispositivoElettronico> dispositivi = new List<DispositivoElettronico>();

    bool continua = true;
    int scelta = 0;

    while (continua)
    {
      Console.WriteLine("1. Aggiungi un dispositivo elettronico.");
      Console.WriteLine("2. Mostra informazioni dispositivo.");
      Console.WriteLine("3. Accendi dispositivo.");
      Console.WriteLine("4. Spegni dispositivo.");
      Console.WriteLine("5. Esci.");
      scelta = Convert.ToInt32(Console.ReadLine());

      switch (scelta)
      {
        case 1:
          Console.WriteLine($"Quale dispositivo vuoi inserire?\n 1.Computer\n 2.Stampante");
          int sceltaDispositivo = Convert.ToInt32(Console.ReadLine());
          if (sceltaDispositivo == 1)
          {
            Console.WriteLine($"Inserisci il modello del computer");
            string? modelloComputer = Console.ReadLine();
            Computer computer = new Computer(modelloComputer);
            dispositivi.Add(computer);
          }
          else if (sceltaDispositivo == 2)
          {
            Console.WriteLine($"Inserisci il modello della stampante");
            string? modelloStampante = Console.ReadLine();
            Stampante stampante = new Stampante(modelloStampante);
            dispositivi.Add(stampante);
          }
          break;
        case 2:
          MostraInfoDispositivo(dispositivi);
          break;
        case 3:
          AccendiDispositivo(dispositivi);
          break;
        case 4:
          SpegniDispositivo(dispositivi);
          break;
        case 5:
          continua = false;
          Console.WriteLine($"Uscita dal programma.");
          break;
      }
    }
  }

  static void MostraInfoDispositivo(List<DispositivoElettronico> d)
  {
    d.ForEach((dispositivo) => dispositivo.MostraInfo());
  }

  static void AccendiDispositivo(List<DispositivoElettronico> d)
  {
    d.ForEach((dispositivo) => dispositivo.Accendi());
  }

  static void SpegniDispositivo(List<DispositivoElettronico> d)
  {
    d.ForEach((dispositivo) => dispositivo.Spegni());
  }
}