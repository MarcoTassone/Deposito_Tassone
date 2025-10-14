using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione14_10.Mattina
{
    public sealed class ConfigurazioneSistema
    {
        private static ConfigurazioneSistema _istanza = new ConfigurazioneSistema();

        private Dictionary<string, string> configurazioni = new Dictionary<string, string>();

        public static ConfigurazioneSistema Istance { get { return _istanza; } }
        private ConfigurazioneSistema() { }

        public static ConfigurazioneSistema GetIstance()
        {
            if(_istanza == null)
            {
                _istanza = new ConfigurazioneSistema();
            }
            return _istanza;
        }

        public void Imposta(string chiave, string valore)
        {
            if(configurazioni.ContainsKey(chiave)) 
            {
                configurazioni[chiave] = valore; 
            }
            else
            {
                configurazioni.Add(chiave, valore);
            }
        }

        public string Leggi(string chiave)
        {
            if (configurazioni.ContainsKey(chiave))
            {
                return configurazioni[chiave];
            }
            else
            {
                return "Errore: chiave non trovata";
            }
        }
        
        public void StampaTutte()
        {
            foreach(var chiave in configurazioni)
            {
                Console.WriteLine(chiave);
            }
        }
    }
}