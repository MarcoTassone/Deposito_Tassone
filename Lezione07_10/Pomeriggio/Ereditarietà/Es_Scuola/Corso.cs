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

        List<string> Studenti;

        public Corso(string nomeCorso, string docente, int durataOre, List<string> studenti)
        {
            NomeCorso = nomeCorso;
            Docente = docente;
            DurataOre = durataOre;
            Studenti = studenti;
        }

        public void AggiungiStudente(string nomeStudente)
        {
            Studenti.Add(nomeStudente);
        }

        public virtual string ToString()
        {
            return $"Corso: {NomeCorso}, Docente: {Docente}, Durata: {DurataOre}, Studenti: {Studenti}";
        }

        public virtual void MetodoSpeciale()
        {
            Console.WriteLine($"");

        }

    public class CorsoMusica : Corso
    {
        public string Strumento;
        public CorsoMusica(string nomeCorso, string docente, int durataOre, List<string> studenti, string strumento) : base(nomeCorso, docente, durataOre, studenti)
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
        public CorsoPittura(string nomeCorso, string docente, int durataOre, List<string> studenti, string tecnica) : base(nomeCorso, docente, durataOre, studenti)
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
        public CorsoDanza(string nomeCorso, string docente, int durataOre, List<string> studenti, string stile) : base(nomeCorso, docente, durataOre, studenti)
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
}
