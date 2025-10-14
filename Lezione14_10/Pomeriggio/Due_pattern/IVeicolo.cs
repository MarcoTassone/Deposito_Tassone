using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione14_10.Pomeriggio.Due_pattern
{
    public sealed class RegistroVeicoli
    {
        private static RegistroVeicoli istanza;
        private List<IVeicolo> veicoliCreati = new List<IVeicolo>();

        private RegistroVeicoli() { }


        public static RegistroVeicoli GetInstanza()
        {
            if (istanza == null)
            {
                istanza = new RegistroVeicoli();
            }
            return istanza;
        }

        public void Registra(IVeicolo veicoli)
        {
            veicoliCreati.Add(veicoli);
            Console.WriteLine($"Veicolo registrato.");
            
        }

        public void StampaTutti()
        {
            foreach (IVeicolo veicolo in veicoliCreati)
            {
                veicolo.Avvia();
                veicolo.MostraTipo();
            }
        }
    }

    public interface IVeicolo
    {
        void Avvia();
        void MostraTipo();
    }

    public class Auto : IVeicolo
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

    public class Moto : IVeicolo
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

    public class Camion : IVeicolo
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

    public static class VeicoloFactoryDP
    {
        public static IVeicolo CreaVeicolo(string tipo)
        {
            switch (tipo.ToLower())
            {
                case "auto":
                    return new Auto();
                case "moto":
                    return new Moto();
                case "camion":
                    return new Camion();
                default:
                    return null;
            }
        }
    }
}