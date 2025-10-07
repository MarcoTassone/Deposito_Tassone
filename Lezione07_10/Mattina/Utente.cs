using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione07_10.Mattina
{
    public class Utente
    {
        public string Nome;
        public int Credito;

        public Utente(string nome, int credito)
        {
            Nome = nome;
            Credito = credito;
        }
    }
}