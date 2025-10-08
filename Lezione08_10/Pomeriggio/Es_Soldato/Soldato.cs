using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;

namespace Lezione08_10.Pomeriggio.Es_Soldato
{
    public class Soldato
    {
        private string nome;
        private string grado;
        private int anniServizio;

        public string Nome
        {
            get { return nome; }
            set
            {
                if (value != " ")
                {
                    nome = value;
                }
            }
        }

        public string Grado
        {
            get { return grado; }
            set
            {
                if (value != " ")
                {
                    grado = value;
                }
            }
        }

        public int AnniServizio
        {
            get { return anniServizio; }
            set
            {
                if (value >= 0)
                {
                    anniServizio = value;
                }
            }
        }

        public Soldato(string nome, string grado, int anniServizio)
        {
            Nome = nome;
            Grado = grado;
            AnniServizio = anniServizio;
        }

        public virtual string Descrizione()
        {
            return $"Nome: {nome}, Grado: {grado}, Anni di servizio: {anniServizio}";
        }
    }

    public class Fante : Soldato
    {
        private string arma;

        public string Arma
        {
            get { return arma; }
            set
            {
                if (value != " ")
                {
                    arma = value;
                }
            }
        }

        public Fante(string nome, string grado, int anniServizio, string arma) : base(nome, grado, anniServizio)
        {
            Arma = arma;
        }

        public override string Descrizione()
        {
            return base.Descrizione() + $" Arma: {arma}";
        }
    }

    public class Artigliere : Soldato
    {
        private int calibro;

        public int Calibro
        {
            get { return calibro; }
            set
            {
                if (value > 0)
                {
                    calibro = value;
                }
            }
        }

        public Artigliere(string nome, string grado, int anniServizio, int calibro) : base(nome, grado, anniServizio)
        {
            Calibro = calibro;
        }

    public override string Descrizione()
    {
        return base.Descrizione() + $" Calibro: {calibro} mm";
    }
    }
}