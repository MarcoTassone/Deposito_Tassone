using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione07_10.Mattina
{
    public class Libro
    {
        public string Titolo;
        public string Autore;
        public int AnnoPubblicazione;

        public Libro(string titolo, string autore, int annoPubblicazione)
        {
            Titolo = titolo;
            Autore = autore;
            AnnoPubblicazione = annoPubblicazione;
        }

        public override string ToString()
        {
            return $"{Titolo} di {Autore} - {AnnoPubblicazione}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Libro altro)
            {
                return Titolo == altro.Titolo && Autore == altro.Autore;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return  HashCode.Combine(Titolo, Autore);
        }
    }
}