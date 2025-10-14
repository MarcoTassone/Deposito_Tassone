// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Lezione14_10.Mattina;
using Lezione14_10.Mattina.FactoryMethod;
using Lezione14_10.Mattina.FactoryMethod.Es_IShape;
using Lezione14_10.Mattina.FactoryMethod.Es_IVeicolo;
using Lezione14_10.Pomeriggio.Due_pattern;

class Program
{
  public static void Main(string[] args)
  {
    // ConfigurazioneSistema ModuloA = ConfigurazioneSistema.Istance;
    // ConfigurazioneSistema ModuloB = ConfigurazioneSistema.Istance;

    // ModuloA.Imposta("chiave1", "valore1");
    // ModuloB.Imposta("chiave2", "valore2");

    // Console.WriteLine($"cose :  {ModuloA.Leggi("chiave1")}");
    // Console.WriteLine($"HashCode ModuloA: {ModuloA.GetHashCode()}");
    // Console.WriteLine($"HashCode ModuloB: {ModuloB.GetHashCode()}");
    // Console.WriteLine($"Sono uguali? {Object.Equals(ModuloA, ModuloB)}");

    // ConfigurazioneSistema.Istance.StampaTutte();

    /// <summary>Factory method</summary>

    // Creator creatorA = new ConcreteCreatorA();
    // creatorA.AnOperation();  // Usa ConcreteProductA

    // Creator creatorB = new ConcreteCreatorB();
    // creatorB.AnOperation();  // Usa ConcreteProductB


    /// <summary>Esercizio factory veicolo</summary>

    // bool continua = true;
    // int scelta;

    // VeicoloFactory AutoFactory= new CreatorVeicoloFactoryAuto();
    // VeicoloFactory MotoFactory = new CreatorVeicoloFactoryMoto();
    // VeicoloFactory CamionFactory = new CreatorVeicoloFactoryCamion();

    // NaveFactory YachtFactory = new CreatorNaveFactoryYacht();
    // NaveFactory PiroscafoFactory = new CreatorNaveFactoryPiroscafo();
    // NaveFactory VelieroFactory = new CreatorNaveFactoryVeliero();
    // while (continua)
    // {
    //   Console.WriteLine($"-----Menu-----");
    //   Console.WriteLine($"1. Inserire quale veicolo creare.");
    //   Console.WriteLine($"2. Inserire quale nave creare. ");
    //   Console.WriteLine($"2. Uscire.");
    //   scelta = int.Parse(Console.ReadLine());

    //   switch (scelta){
    //     case 1:
    //       Console.WriteLine($"Che tipo di veicolo vuoi creare?\nAuto\nMoto\nCamion");
    //       string? sceltaVeicolo = Console.ReadLine().ToLower();
    //       switch (sceltaVeicolo)
    //       {
    //         case "auto":
    //           AutoFactory.AvviaVeicolo();
    //           AutoFactory.MostraTipoVeicolo();
    //           break;
    //         case "moto":
    //           MotoFactory.AvviaVeicolo();
    //           MotoFactory.MostraTipoVeicolo();
    //           break;
    //         case "camion":
    //           CamionFactory.AvviaVeicolo();
    //           CamionFactory.MostraTipoVeicolo();
    //           break;
    //       }
    //       break;
    //     case 2:
    //       Console.WriteLine($"Che tipo di nave vuoi crearea?\nYacht\nPiroscafo\nVeliero");
    //       string? sceltaNave = Console.ReadLine().ToLower();
    //       switch (sceltaNave)
    //       {
    //         case "yacht":
    //           YachtFactory.AvviaNave();
    //           YachtFactory.MostraTipoNave();
    //           break;
    //         case "piroscafo":
    //           PiroscafoFactory.AvviaNave();
    //           PiroscafoFactory.MostraTipoNave();
    //           break;
    //         case "veliero":
    //           VelieroFactory.AvviaNave();
    //           VelieroFactory.MostraTipoNave();
    //           break;
    //       }
    //       break;
    //     case 3:
    //     Console.WriteLine($"Arrivederci!");
    //       continua = false;
    //       break;
    //     default:
    //       Console.WriteLine($"Scelta non valida.");
    //       break;
    //   }
    // }



    /// <summary>Esercizio factory forma</summary>


    // bool continua = true;
    // int scelta;

    // while (continua)
    // {
    //   Console.WriteLine($"-----Menu-----");
    //   Console.WriteLine($"1. Inserire quale forma creare.");
    //   Console.WriteLine($"2. Uscire.");
    //   scelta = int.Parse(Console.ReadLine());

    //   switch (scelta)
    //   {
    //     case 1:
    //       Console.WriteLine($"Quale forma vuoi creare?\nCerchio\nQuadrato");
    //       string? sceltaForma = Console.ReadLine().ToLower();
    //       switch (sceltaForma)
    //       {
    //         case "cerchio":
    //           ShapeCreator.CreateShape(sceltaForma);
    //           break;
    //         case "quadrato":
    //           ShapeCreator.CreateShape(sceltaForma);
    //           break;
    //       }
    //       break;
    //     case 2:
    //       Console.WriteLine($"Arrivederci!");
    //       continua = false;
    //       break;
    //     default:
    //       Console.WriteLine($"Scelta non valida.");
    //       break;
    //   }
    // }


    /// <summary>Esercizio veicolo con due pattern</summary>

    // RegistroVeicoli veicoli = RegistroVeicoli.GetInstanza();



    // bool continua = true;
    // int scelta;

    // while (continua)
    // {
    //   Console.WriteLine($"-----Menu-----");
    //   Console.WriteLine($"1. Inserire quale veicolo creare.");
    //   Console.WriteLine($"2. Stampa dettagli.");
    //   Console.WriteLine($"3. Uscire.");
    //   scelta = int.Parse(Console.ReadLine());

    //   switch (scelta)
    //   {
    //     case 1:
    //       Console.WriteLine($"Che tipo di veicolo vuoi creare?\nAuto\nMoto\nCamion");
    //       string? sceltaVeicolo = Console.ReadLine().ToLower();
    //       VeicoloFactoryDP.CreaVeicolo(sceltaVeicolo);
    //       switch (sceltaVeicolo)
    //       {
    //         case "auto":
    //           veicoli.Registra(VeicoloFactoryDP.CreaVeicolo(sceltaVeicolo));
    //           break;
    //         case "moto":
    //           veicoli.Registra(VeicoloFactoryDP.CreaVeicolo(sceltaVeicolo));
    //           break;
    //         case "camion":
    //           veicoli.Registra(VeicoloFactoryDP.CreaVeicolo(sceltaVeicolo));
    //           break;
    //       }
    //       break;
    //     case 2:
    //       veicoli.StampaTutti();
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


    ConfigurazioneSistemaDP ModuloA = ConfigurazioneSistemaDP.GetInstanza();
    ConfigurazioneSistemaDP ModuloB = ConfigurazioneSistemaDP.GetInstanza();

    Console.WriteLine($"sono uguali? {object.ReferenceEquals(ModuloA, ModuloB)}");


    

    bool continua = true;
    int scelta;

    while (continua)
    {
      Console.WriteLine($"-----Menu-----");
      Console.WriteLine($"1. Inserire quale dispositivo creare.");
      Console.WriteLine($"2. Stampa dettagli.");
      Console.WriteLine($"3. Controlla se puntano alla stessa istanza");
      Console.WriteLine($"4. Uscire.");
      scelta = int.Parse(Console.ReadLine());

      switch (scelta)
      {
        case 1:
          Console.WriteLine($"Quale dispositivo vuoi creare?\nComputer\nStampante");
          string? sceltaDispositivo = Console.ReadLine().ToLower();
          DispositivoFactory.CreaDispositivo(sceltaDispositivo);
          switch (sceltaDispositivo)
          {
            case "computer":
              Console.WriteLine($"Inserire chiave e valore: ");
              string? sceltaChiaveComputer = Console.ReadLine().ToLower();
              Console.WriteLine($"chiave inserita.");
              string? sceltaValoreComputer = Console.ReadLine().ToLower();
              Console.WriteLine($"valore inserito");
              ModuloA.Imposta(sceltaChiaveComputer, sceltaValoreComputer);
              break;
            case "stampante":
              Console.WriteLine($"Inserire chiave e valore: ");
              string? sceltaChiaveStampante = Console.ReadLine().ToLower();
              Console.WriteLine($"chiave inserita.");
              string? sceltaValoreStampante = Console.ReadLine().ToLower();
              Console.WriteLine($"valore inserito");
              ModuloB.Imposta(sceltaChiaveStampante, sceltaValoreStampante);
              break;
          }
          break;
        case 2:
          ModuloA.StampaTutte();
          ModuloB.StampaTutte();
          break;
        case 3:
          Console.WriteLine($"HashCode ModuloA: {ModuloA.GetHashCode()}");
          Console.WriteLine($"HashCode ModuloB: {ModuloB.GetHashCode()}");
          Console.WriteLine($"Sono uguali? {object.ReferenceEquals(ModuloA, ModuloB)}");
          break;
        case 4:
          Console.WriteLine($"Arrivederci!");
          continua = false;
          break;
        default:
          Console.WriteLine("Scelta non valida");
          break;
      }
    }
  }
}
