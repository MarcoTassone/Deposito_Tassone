using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione06_10.Esempi
{
    public class Operazioni
    {

        int n1;
        int n2;

        public int Somma(int a, int b)
        {
            return a + b;
        }

        public int Moltiplica(int a, int b)
        {
            return a * b;
        }

        public void InserisciNumeri()
        {
            Console.WriteLine($"Inserisci un numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Inserisci un secondo numero: ");
            n2 = int.Parse(Console.ReadLine());

        }

        public void StampaRisultato(string operazione, int risultato)
        {
            Console.WriteLine($"Il risultato dell'operazione {operazione} è {risultato}");
        }

        
    }
}