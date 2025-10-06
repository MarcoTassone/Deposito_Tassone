using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione06_10.Esempi
{
    public class StudenteTreParametri
    {
        public string Nome;
        public string Cognome;
        public int AnnoNascita;

        public StudenteTreParametri(string nome, string cognome, int annoNascita)
        {
            Nome = nome;
            Cognome = cognome;
            AnnoNascita = annoNascita;
        }
        
        public void Stampa()
        {
            Console.WriteLine($"Ciao sono {Nome} {Cognome} e sono nato nel {AnnoNascita}.");
        }
    }
}