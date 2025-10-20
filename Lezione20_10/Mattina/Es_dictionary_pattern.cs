using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione20_10.Mattina
{

    #region Strategy
    public interface ICalcoloInteressi
    {
        decimal CalcolaInteressi(decimal saldo);
    }

    public class InteressiBase : ICalcoloInteressi
    {
        public decimal CalcolaInteressi(decimal saldo)
        {
            return saldo * 0.01m;
        }
    }

    public class InteressiPremium : ICalcoloInteressi
    {
        public decimal CalcolaInteressi(decimal saldo)
        {
            return saldo * 0.03m;
        }
    }

    public class InteressiStudent : ICalcoloInteressi
    {
        public decimal CalcolaInteressi(decimal saldo)
        {
            return saldo * 0.002m;
        }
    }
    #endregion

    #region Observer
    public interface IObserver
    {
        void Update(string evento);
    }

    public interface ILogger : IObserver { }

    public class ConsoleLogger : ILogger
    {
        public void Update(decimal evento)
        {
            Console.WriteLine($"Saldo aggiornato: {evento}");
        }
    }

    #endregion
    
    #region Singleton
    public sealed class BankContext
    {
        private static BankContext _istance;

        private BankContext() { }

        public static BankContext GetIstance()
        {
            if (_istance == null)
            {
                _istance = new BankContext();
            }
            return _istance;
        }
        public Dictionary<int, Cliente> Clienti = new Dictionary<int, Cliente>();
        public Dictionary<int, Conto> Conti = new Dictionary<int, Conto>();
        public Dictionary<int, List<Operazione>> Operazioni = new Dictionary<int, List<Operazione>>();

        private readonly List<IObserver> observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        
        public void Notify(string evento)
        {
            foreach (var observer in observers)
            {
                observer.Update(evento);
            }
        }
    }
    #endregion

    #region Cliente
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public string? Email { get; set; }
    }
    #endregion


    #region Factory
    public abstract class Conto
    {
        public int Id { get; }
        public decimal Saldo { get; protected set; }
        public string? Tipo { get; set; }
        public int IdCliente { get; }
        public ICalcoloInteressi? CalcoloInteressi { get; set; }

        public Conto(int id, string? tipo, int idCliente, decimal saldo = 0)
        {
            Id = id;
            Saldo = saldo;
            Tipo = tipo;
            IdCliente = idCliente;
        }

        public void Deposita(decimal importo)
        {
            Saldo += importo;
        }

        public bool Preleva(decimal importo)
        {
            if (Saldo < importo) return false;
            Saldo -= importo;
            return true;
        }

        public void ApplicaInteressi(decimal importo)
        {
            Saldo += CalcoloInteressi.CalcolaInteressi(importo);
        }
    }

    public class ContoBase : Conto
    {
        public ContoBase(int id, int idCliente) : base(id, "Conto base", idCliente) { }
    }

    public class ContoPremium : Conto
    {
        public ContoPremium(int id, int idCliente) : base(id, "Conto premium", idCliente) { }
    }
    
    
    public class ContoStudente : Conto
    {
        public ContoStudente(int id, int idCliente) : base(id, "Conto studente", idCliente) { }
    }
    #endregion
}