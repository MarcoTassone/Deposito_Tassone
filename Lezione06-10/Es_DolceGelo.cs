namespace Es_DolceGelo
{
  public class Es_DolceGelo
  {
    public static void DolceGelo()
    {

      string[] gusti = { "Cioccolato", "Fragola", "Menta", "Pistacchio", "Limone" };
      double[] prezzi = { 1.50, 1.30, 1.40, 1.60, 1.70 };
      int indice;

      static void Main()
      {
        Console.WriteLine($"Benvenuto nella gelateria Dolce Gelo!");

        StampaMenu(gusti, prezzi);

        indice = int.Parse(Console.ReadLine());

        Console.WriteLine($"Inserire la quantità di palline: ");
        
        
        
        
        
      }
      
      static int StampaMenu(string[] gusti, double[] prezzi)
      {
        for (int i = 0; i < gusti.Length; i++)
        {
          Console.WriteLine($"{i} - {gusti[i]} - {prezzi[i].ToString()} euro");
        }
      }
      
      static int CalcolaTotale(int gusto, int quantita){
        double totale = prezzi[gusto] * quantita;
        return totale;
      }
    }
  }
}