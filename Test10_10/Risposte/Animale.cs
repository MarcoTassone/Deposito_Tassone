using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test10_10
{
    public class Animale
    {
        private string? _nome;
        private int _anni;

        public string? Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public int Anni
        {
            get { return _anni; }
            set
            {
                if (value >= 0)
                {
                    _anni = value;
                }
            }
        }

        public Animale(string? nome, int anni)
        {
            Nome = nome;
            Anni = anni;
        }

        public virtual void FaiVerso()
        {
            Console.WriteLine($"L'animale fa un verso.");
        }

        public virtual void Stampa()
        {
            Console.WriteLine($"{Nome} ha {Anni} anni.");
        }
    }

    public class Cane : Animale
    {

        public string? Razza { get; set; }

        public Cane(string nome, int anni, string razza) : base(nome, anni)
        {
            Razza = razza;
        }

        public override void FaiVerso()
        {
            base.FaiVerso();
            Console.WriteLine($"Il cane {Nome} fa: Bau!.");
        }

        public override void Stampa()
        {
            Console.WriteLine($"{base.Stampa}, ed è di razza: {Razza}");
        }
    }

    public class Gatto : Animale
    {
        public string? Colore { get; set; }
        public Gatto(string? nome, int anni, string colore) : base(nome, anni)
        {
            Colore = colore;
        }

        public override void FaiVerso()
        {
            Console.WriteLine($"Il gatto {Nome} fa: Miau!");
        }

        public override void Stampa()
        {
            Console.WriteLine($"{base.Stampa}, ha il colore: {Colore}");
        }
    }
}
