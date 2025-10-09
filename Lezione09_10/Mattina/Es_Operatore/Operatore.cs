using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione09_10.Mattina.Es_Operatore
{
    public class Operatore
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

    public class OperatoreEmergenza : Operatore
    {
        public int LivelloUrgenza
        {
            get { return LivelloUrgenza; }
            set
            {
                if (value >= 1 && value <= 5)
                {
                    LivelloUrgenza = value;
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
    }

    public class OperatoreSicurezza : Operatore
    {
        public string AreaSorvegliata
        {
            get { return AreaSorvegliata; }
            set
            {
                if (value != " ")
                {
                    AreaSorvegliata = value;
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
    }

    public class OperatoreLogistica : Operatore
    {
        public int NumeroConsegne
        {
            get { return NumeroConsegne; }
            set
            {
                if (value >= 0)
                {
                    NumeroConsegne = value;
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
    }
}