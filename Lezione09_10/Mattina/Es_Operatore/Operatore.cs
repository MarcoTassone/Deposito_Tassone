using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione09_10.Mattina.Es_Operatore
{
    public class Operatore  //Classe padre
    {
        private string nome;
        private string turno;

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

        public string Turno
        {
            get { return turno; }
            set
            {
                if (value == "giorno" || value == "notte")
                {
                    turno = value;
                }
            }
        }

        public Operatore(string nome, string turno)
        {
            Nome = nome;
            Turno = turno;
        }

        public virtual string EseguiCompito()
        {
            return $"Operatore generico in servizio.";
        }

        public virtual string Stampa()
        {
            return $"Operatore: {Nome}, Turno: {Turno}, Servizio: {EseguiCompito()}.";
        }
    }

    public class OperatoreEmergenza : Operatore  //classe figlio1
    {
        private int livelloUrgenza;
        public int LivelloUrgenza
        {
            get { return livelloUrgenza; }
            set
            {
                if (value >= 1 && value <= 5)
                {
                    livelloUrgenza = value;
                }
            }
        }

        public OperatoreEmergenza(string nome, string turno, int livelloUrgenza) : base(nome, turno)
        {
            LivelloUrgenza = livelloUrgenza;
        }

        public override string EseguiCompito()
        {
            return $"Gestione emergenza di livello {LivelloUrgenza}.";
        }

        public override string Stampa()
        {
            return $"Nome operatore emergenza: {Nome}, Turno: {Turno}, Livello urgenza: {LivelloUrgenza}, Compito: {EseguiCompito()}. ";
        }
    }

    public class OperatoreSicurezza : Operatore  //classe figlio2
    {

        private string areaSorvegliata;

        public string AreaSorvegliata
        {
            get { return areaSorvegliata; }
            set
            {
                if (value != " ")
                {
                    areaSorvegliata = value;
                }
            }
        }
        public OperatoreSicurezza(string nome, string turno, string areaSorvegliata) : base(nome, turno)
        {
            AreaSorvegliata = areaSorvegliata;
        }

        public override string EseguiCompito()
        {
            return $"Sorveglianza dell'area {AreaSorvegliata}.";
        }

        public override string Stampa()
        {
            return $"Nome operatore sicurezza: {Nome}, Turno: {Turno}, Area sorvegliata: {AreaSorvegliata}, Compito: {EseguiCompito()}. ";
        }
    }

    public class OperatoreLogistica : Operatore  //classe figlio3
    {
        private int numeroConsegne;
        public int NumeroConsegne
        {
            get { return numeroConsegne; }
            set
            {
                if (value >= 0)
                {
                    numeroConsegne = value;
                }
            }
        }
        public OperatoreLogistica(string nome, string turno, int numeroConsegne) : base(nome, turno)
        {
            NumeroConsegne = numeroConsegne;
        }

        public override string EseguiCompito()
        {
            return $"Coordinamente di {NumeroConsegne} consegne.";
        }
        
        public override string Stampa()
        {
            return $"Nome operatore logistica: {Nome}, Turno: {Turno}, Numero consegne: {NumeroConsegne}, Compito: {EseguiCompito()}. ";
        }
    }
}