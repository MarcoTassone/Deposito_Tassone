// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using Lezione06_10;
using Lezione06_10.Mattina;
using Lezione06_10.Esempi;

class Program
{

  public static void Main(string[] args)
  {
    // Es_DolceGelo dolceGelo = new Es_DolceGelo();
    // dolceGelo.Menu();
    
    MioCane cane = new MioCane();

    cane.nome = "Fido";
    cane.eta = 3;

    cane.Abbaia();

    Persona persona = new Persona("Marco", 24);
    Persona persona2 = new Persona("Francesco", 40);
    persona.Presentati();
    persona2.Presentati();

    Studente studente = new Studente();
    studente.S1();
    studente.S2();

  }
}