using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione07_10.Pomeriggio.Ereditarietà
{
    public class Animale
    {
        protected int eta;
        public virtual void FaiVerso()
        {
            Console.WriteLine($"L'animale fa un verso.");
        }

        public virtual void Mangia()
        {
            Console.WriteLine($"L'animale mangia.");
        }


    }

    public class Cane : Animale
    {
        public void Scondizola()
        {
            Console.WriteLine($"Il cane scondizola.");
        }

        public override void Mangia()
        {
            Console.WriteLine($"Il cane mangia.");
        }

        public override void FaiVerso()
        {
            base.FaiVerso();
            Console.WriteLine($"Il cane fa tanti versi.");
        }
    }

    public class Gatto : Animale
    {
        public new void FaiVerso()
        {
            Console.WriteLine($"Il gatto miagola.");
        }
    }
    
    public class Elefante : Animale
    {
        public void ImpostaEta(int nuovaEta)
        {
            eta = nuovaEta;
        }
    }
}
