using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione08_10.Pomeriggio.Esempi_Polimorfismo
{
    public class Forma
    {
        public virtual double CalcolaArea()
        {
            return 0;
        }
    }

    public class Rettangolo : Forma
    {
        public double Base { get; set; }
        public double Altezza { get; set; }

        public override double CalcolaArea()
        {
            return Base * Altezza;
        }

        // public override double CalcolaArea(double a, double b)
        // {
        //     return a + b;
        // }
    }

    public class Cerchio : Forma
    {
        public double Raggio { get; set; }

        public override double CalcolaArea()
        {
            return Math.PI * Raggio * Raggio;
        }
    }
}