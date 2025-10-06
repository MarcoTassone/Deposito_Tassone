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

        public void Studente1(string nome, string cognome, int annoNascita)
        {
            Nome = nome;
            Cognome = cognome;
            AnnoNascita = annoNascita;
        }
        
        public void Studente2()
        {
            Nome = "Giovanni";
            Cognome = "Rossi";
            AnnoNascita = 2002;
            Console.WriteLine($"Ciao sono {Nome} {Cognome} e ho {AnnoNascita} anni.");
        }
    }
}