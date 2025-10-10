using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione10_10.Pomeriggio.Es_Corsi
{
    public abstract class Corso
    {
        private string? _titolo;
        private int _durataOre;
        public string? Titolo
        {
            get
            {
                return _titolo;
            }
            set
            {
                if (value != null)
                {
                    _titolo = value;
                }
            }
        }
        public int DurataOre
        {
            get
            {
                return _durataOre;
            }
            set
            {
                if (value > 0)
                {
                    _durataOre = value;
                }
            }
        }

        public Corso(string? titolo, int durataOre)
        {
            Titolo = titolo;
            DurataOre = durataOre;
        }

        public abstract void ErogaCorso();

        public abstract void StampaDettagli();
    }


    public class CorsoInPresenza : Corso
    {
        private int _numeroPosti;
        private string? _aula;

        public int NumeroPosti
        {
            get { return _numeroPosti; }
            set
            {
                if (value > 0)
                {
                    _numeroPosti = value;
                }
            }
        }
        public string? Aula
        {
            get { return _aula; }
            set
            {
                if (value != null)
                {
                    _aula = value;
                }
            }
        }

        public CorsoInPresenza(string? titolo, int durataOre, int numeroPosti, string aula) : base(titolo, durataOre)
        {
            NumeroPosti = numeroPosti;
            Aula = aula;
        }

        public override void ErogaCorso()
        {
            Console.WriteLine($"Il corso in presenza è stato erogato.");
        }

        public override void StampaDettagli()
        {
            Console.WriteLine($"Titolo: {Titolo}");
            Console.WriteLine($"Durata: {DurataOre} ore");
            Console.WriteLine($"Numero posti: {NumeroPosti}");
            Console.WriteLine($"Aula: {Aula}");
            Console.WriteLine($"============================================");
        }
    }


    public class CorsoOnline : Corso
    {
        private string? _piattaforma;
        private string? _linkAccesso;

        public string? Piattaforma
        {
            get { return _piattaforma; }
            set
            {
                if (value != null)
                {
                    _piattaforma = value;
                }
            }
        }

        public string? LinkAccesso
        {
            get { return _linkAccesso; }
            set
            {
                if (value != null)
                {
                    _linkAccesso = value;
                }
            }
        }

        public CorsoOnline(string? titolo, int durataOre, string piattaforma, string linkAccesso) : base(titolo, durataOre)
        {
            Piattaforma = piattaforma;
            LinkAccesso = linkAccesso;
        }

        public override void ErogaCorso()
        {
            Console.WriteLine($"Il corso online è stato erogato.");
        }

        public override void StampaDettagli()
        {
            Console.WriteLine($"Titolo: {Titolo}");
            Console.WriteLine($"Durata: {DurataOre} ore");
            Console.WriteLine($"Piattaforma: {Piattaforma}");
            Console.WriteLine($"Link di accesso: {LinkAccesso}");
            Console.WriteLine($"============================================");
        }
    }
}