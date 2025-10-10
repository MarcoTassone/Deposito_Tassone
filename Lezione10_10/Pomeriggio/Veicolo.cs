using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione10_10.Pomeriggio
{
    public abstract class Veicolo
    {
        public abstract void Avvia();
    }

    // Classe concreta che eredita dalla classe astratta
    public class Auto : Veicolo
    {
        public override void Avvia()
        {
            Console.WriteLine("L'auto si accende.");
        }
    }

    // Interfaccia
    public interface IVeicoloElettrico
    {
        void Ricarica();
    }

    // Classe che implementa l'interfaccia
    public class ScooterElettrico : IVeicoloElettrico
    {
        public void Ricarica()
        {
            Console.WriteLine("Scooter in carica.");
        }
    }
}