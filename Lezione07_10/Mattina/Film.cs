using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione07_10.Mattina
{
    public class Film
    {
        List<string> films = new List<string>();
        public string Titolo;
        public string Regista;
        public int Anno;
        public string Genere;

        public Film(string titolo, string regista, int anno, string genere)
        {
            Titolo = titolo;
            Regista = regista;
            Anno = anno;
            Genere = genere;
            films.Add(titolo + ", " + regista + ", " + anno + ", " + genere);
        }

        public void Stampa()
        {
            foreach (string f in films)
            {
                Console.WriteLine(f);
            }
        }

        public void cercaFilm(string genere)
        {
            foreach (string f in films)
            {
                if (f.Contains(genere))
                {
                    Console.WriteLine(f);
                }
            }
        }
    }
}