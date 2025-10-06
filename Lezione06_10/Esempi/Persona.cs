using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione06_10.Esempi
{
    public class Persona
    {
        public string Nome;
        public int Eta;

        public Persona(string nome, int eta)
        {
            Nome = nome;
            Eta = eta;
        }

        public void Presentati()
        {
            Console.WriteLine($"Ciao sono {Nome} e ho {Eta} anni.");
        }
    }
}