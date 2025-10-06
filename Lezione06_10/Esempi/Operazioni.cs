using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione06_10.Esempi
{
    public class Operazioni
    {

        public static double Somma(double a, double b)
        {
            return a + b;
        }

        public static double Moltiplica(double a, double b)
        {
            return a * b;
        }

        public void StampaRisultato(string operazione, double risultato)
        {
            Console.WriteLine($"Il risultato dell'operazione {operazione} è {risultato}");
        }

        
    }
}