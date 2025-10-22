// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Lezione22_10.Mattina;

class Program
{
  public static void Main(string[] args)
  {
    new ConsoleUI(new ProdottoService(new ProdottoRepositoryMem())).Run();
  }
}