using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Lezione14_10.Mattina.FactoryMethod.Es_IVeicolo
{
    public interface Iveicolo
    {
        void Avvia();
        void MostraTipo();
    }

    public class ConcreteVeicoloAuto : Iveicolo
    {
        public void Avvia()
        {
            Console.WriteLine("Avvio dell'auto.");
        }

        public void MostraTipo()
        {
            Console.WriteLine("Tipo: Auto.");
        }
    }

    public class ConcreteVeicoloMoto : Iveicolo
    {
        public void Avvia()
        {
            Console.WriteLine("Avvio della moto.");
        }

        public void MostraTipo()
        {
            Console.WriteLine("Tipo: Moto.");
        }
    }

    public class ConcreteVeicoloCamion : Iveicolo
    {
        public void Avvia()
        {
            Console.WriteLine("Avvio del camion.");
        }

        public void MostraTipo()
        {
            Console.WriteLine("Tipo: Camion.");
        }
    }

    public abstract class VeicoloFactory
    {
        public static Iveicolo CreateVeicolo(string tipo)
        {
            switch (tipo.ToLower())
            {
                case "auto":
                    return new ConcreteVeicoloAuto();
                case "moto":
                    return new ConcreteVeicoloMoto();
                case "camion":
                    return new ConcreteVeicoloCamion();
                default:
                    Console.WriteLine($"Tipo di veicolo non valido");
                    break;
            }
            return null;
        }
    }
}