using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Lezione06_10.Esempi
{
    public class Studente
    {
        public string Nome;
        public int Matricola;
        public double MediaVoti;

        public void S1()
        {
            Nome = "Giovanni";
            Matricola = 45678;
            MediaVoti = 6.7;
            Console.WriteLine($"Ciao sono {Nome} il mio numero di matricola è {Matricola} ed ho una media di {MediaVoti}.");
        }

        public void S2()
        {
            Nome = "Mario";
            Matricola = 98653;
            MediaVoti = 5.3;
            Console.WriteLine($"Ciao sono {Nome} il mio numero di matricola è {Matricola} ed ho una media di {MediaVoti}.");
        }
    }
}