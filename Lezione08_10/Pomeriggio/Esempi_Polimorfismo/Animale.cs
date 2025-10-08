using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione08_10.Mattina.Esempi_Incapsulamento.Esempi_Polimorfismo
{
    public class Animale
    {
        public virtual void FaiVerso()
        {
            Console.WriteLine($"L'animale fa un verso.");

        }
    }

    public class Cane : Animale
    {
        public override void FaiVerso()
        {
            Console.WriteLine($"Il cane abbaia.");
        }
    }

    public class Gatto : Animale
    {
        public override void FaiVerso()
        {
            Console.WriteLine($"Il gatto miagola.");

        }
    }
}