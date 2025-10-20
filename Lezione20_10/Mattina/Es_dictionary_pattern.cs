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

    public static class Conto
    {
        
    }
}