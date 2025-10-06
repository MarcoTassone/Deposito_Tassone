using System.Security.Cryptography.X509Certificates;

namespace Lezione06_10.Mattina
{
  public class Es_DolceGelo
  {


    string[] gusti = { "Cioccolato", "Fragola", "Menta", "Pistacchio", "Limone" };
    double[] prezzi = { 1.50, 1.30, 1.40, 1.60, 1.70 };
    int indice;

    bool continua = true;

    public void Menu()
    {
      Console.WriteLine($"Benvenuto nella gelateria Dolce Gelo!");

      while (continua)
      {
        StampaMenu(gusti, prezzi);

        Console.WriteLine($"Inserisci scegli un gusto: ");

        indice = int.Parse(Console.ReadLine());

        Console.WriteLine($"Inserire la quantità di palline: ");

        int quantita = int.Parse(Console.ReadLine());

        Console.WriteLine($"Vuoi inserire un altro gusto? (s/n)");

        string risposta = Console.ReadLine();

        if (risposta == "n")
        {
          continua = false;
        }
      }
    }
    static void StampaMenu(string[] gusti, double[] prezzi)
    {
      for (int i = 0; i < gusti.Length; i++)
      {
        Console.WriteLine($"{i + 1} - {gusti[i]} - {prezzi[i].ToString()} euro");
      }
    }

    double CalcolaTotale(int gusto, int quantita)
    {
      double totale = prezzi[gusto] * quantita;
      return totale;
    }
  }
}
