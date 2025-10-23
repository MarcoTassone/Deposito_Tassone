using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione23_10.Mattina
{
    public class Utente
    {
        public string? Nome { get; set; }

        public Utente(string? Nome)
        {
            this.Nome = Nome;
        }
    }
}