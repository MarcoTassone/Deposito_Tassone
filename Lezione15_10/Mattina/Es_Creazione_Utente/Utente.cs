using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione15_10.Mattina.Es_Creazione_Utente
{
    public class Utente
    {
        private string _nome { get; set; }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null)
                {
                    _nome = value;
                }
            }
        }

        public Utente(string nome)
        {
            _nome = nome;
        }

        public override string ToString()
        {
            return $"Nome dell'utente: {Nome}";
        }
    }
}