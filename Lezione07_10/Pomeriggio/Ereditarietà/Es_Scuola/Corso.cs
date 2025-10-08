using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione07_10.Pomeriggio.Ereditarietà.Es_Scuola
{
    public class Corso
    {
        public string NomeCorso, Docente;
        int DurataOre;

        public List<string> Studenti = new List<string>();

        public Corso(string nomeCorso, string docente, int durataOre)
        {
            NomeCorso = nomeCorso;
            Docente = docente;
            DurataOre = durataOre;
        }

        public void AggiungiStudente(string nomeStudente)
        {
            Studenti.Add(nomeStudente);
        }

        public override string ToString()
        {
            if (Studenti.Count == 0)
            {
                return $"Corso: {NomeCorso}, Docente: {Docente}, Durata: {DurataOre}";
            }
            return $"Corso: {NomeCorso}, Docente: {Docente}, Durata: {DurataOre}, Studenti: {Studenti.Count}";
        }

        public virtual void MetodoSpeciale()
        {
            Console.WriteLine($"");

        }
    }

    public class CorsoMusica : Corso
    {
        public string Strumento;
        public CorsoMusica(string nomeCorso, string docente, int durataOre, string strumento) : base(nomeCorso, docente, durataOre)
        {
            Strumento = strumento;
        }

        public override string ToString()
        {
            return base.ToString() + ", Strumento: " + Strumento;
        }

        public override void MetodoSpeciale()
        {
            Console.WriteLine($"Si tiene una prova pratica dello strumento: " + Strumento);
        }
    }

    public class CorsoPittura : Corso
    {
        public string Tecnica;
        public CorsoPittura(string nomeCorso, string docente, int durataOre, string tecnica) : base(nomeCorso, docente, durataOre)
        {
            Tecnica = tecnica;
        }

        public override string ToString()
        {
            return base.ToString() + ", Tecnica: " + Tecnica;
        }

        public override void MetodoSpeciale()
        {
            Console.WriteLine($"Si lavora su una tela con tecnica: " + Tecnica);
        }
    }

    public class CorsoDanza : Corso
    {
        public string Stile;
        public CorsoDanza(string nomeCorso, string docente, int durataOre, string stile) : base(nomeCorso, docente, durataOre)
        {
            Stile = stile;
        }

        public override string ToString()
        {
            return base.ToString() + ", Stile: " + Stile;
        }

        public override void MetodoSpeciale()
        {
            Console.WriteLine("Esecuzione coreografia nello stile: " + Stile);
        }
    }
}

