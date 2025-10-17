using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;

namespace Lezione17_10.Pomeriggio
{
    public static class TelefonoDizionario
    {
        public static Dictionary<string, string> NumeroTelefono = [];

        public static void AggiungiNumero()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Inserisci il nome: ");
                string? nome = Console.ReadLine();
                Console.WriteLine($"Inserisci il numero di telefono: ");
                string? telefono = Console.ReadLine();
                NumeroTelefono.Add(nome, telefono);
            }
        }

        public static void Stampa()
        {
            foreach (var telefono in NumeroTelefono)
            {
                Console.WriteLine($"Nome: {telefono.Key}, telefono: {telefono.Value}");
            }
        }
    }

    public static class Frasi
    {

        static string[] parole;
        public static Dictionary<string, int> Frase = new Dictionary<string, int>();

        public static void Aggiungi()
        {
            Console.WriteLine($"Inserisci una frase: ");
            string? frase = Console.ReadLine();
            parole = frase.Split(' ');

            foreach (var parola in parole)
            {
                string pulita = parola.Trim().ToLower();
                if (Frase.ContainsKey(pulita))
                {
                    Frase[pulita]++;
                }
                else
                {
                    Frase[pulita] = 1;
                }
            }
        }

        public static void Stampa()
        {
            foreach (var parola in Frase)
            {
                Console.WriteLine($"Parola: {parola.Key}, occorrenze: {parola.Value}");
            }
        }
    }
    
    
}