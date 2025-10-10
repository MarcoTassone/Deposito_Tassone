using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione10_10.Pomeriggio.Interfaccia_Pagamento
{
    public class Utente
    {
        public string Nome { get; set; }
        private int _pin;

        public int Pin
        {
            get { return _pin; }
            set { _pin = value; }
        }

        public Utente(string nome, int pin)
        {
            Nome = nome;
            Pin = pin;
        }
    }
}