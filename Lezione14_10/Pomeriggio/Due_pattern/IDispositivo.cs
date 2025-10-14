using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Lezione14_10.Pomeriggio.Due_pattern
{

    public sealed class ConfigurazioneSistemaDP
    {
        private Dictionary<string, string> _configurazione;

        private ConfigurazioneSistemaDP()
        {
            _configurazione = new Dictionary<string, string>();
        }
        
        private static ConfigurazioneSistemaDP _istanza;
        public static ConfigurazioneSistemaDP GetInstanza()
        {
            if (_istanza == null)
            {
                _istanza = new ConfigurazioneSistemaDP();
            }
            return _istanza;
        }

        public void Imposta(string chiave, string valore)
        {
            if (_configurazione.ContainsKey(chiave))
            {
                _configurazione[chiave] = valore;
            }
            else
            {
                _configurazione.Add(chiave, valore);
            }
        }

        public void Leggi(string chiave)
        {
            if (_configurazione.ContainsKey(chiave))
            {
                Console.WriteLine(_configurazione[chiave]);
            }
            else
            {
                Console.WriteLine($"La chiave non esiste.");
            }
        }

        public void StampaTutte()
        {
            foreach (var chiave in _configurazione)
            {
                Console.WriteLine(chiave);
            }
        }
    }

    public interface IDispositivo
    {
        void Avvia();
        void MostraTipo();
    }


    public class Computer : IDispositivo
    {
        public void Avvia()
        {
            Console.WriteLine("Il computer si avvia.");
        }

        public void MostraTipo()
        {
            Console.WriteLine("Tipo: Computer.");
        }
    }

    public class Stampante : IDispositivo
    {
        public void Avvia()
        {
            Console.WriteLine("La stampante si avvia.");
        }

        public void MostraTipo()
        {
            Console.WriteLine("Tipo: Stampante.");
        }
    }

    public abstract class DispositivoFactory
    {
        public static IDispositivo CreaDispositivo(string tipo)
        {
            switch (tipo.ToLower())
            {
                case "computer":
                    return new Computer();
                case "stampante":
                    return new Stampante();
                default:
                    return null;
            }
        }
    }
}