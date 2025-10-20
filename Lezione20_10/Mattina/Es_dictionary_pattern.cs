using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Lezione20_10.Mattina
{

    #region Strategy
    public interface ICalcoloInteressi
    {
        decimal CalcolaInteressi(decimal saldo);
        decimal Commissioni(Conto from, decimal importo);
    }

    public class InteressiBase : ICalcoloInteressi
    {
        public decimal CalcolaInteressi(decimal saldo)
        {
            return saldo * 0.02m;
        }

        public decimal Commissioni(Conto from, decimal importo)
        {
            return .50m;
        }
    }

    public class InteressiPremium : ICalcoloInteressi
    {
        public decimal CalcolaInteressi(decimal saldo)
        {
            return saldo * 0.03m;
        }

        public decimal Commissioni(Conto from, decimal importo)
        {
            if (importo < 100)
        {
            return 0;
        }
        else
        {
            return Math.Round(importo * 0.02m, 1);
        }
        }
    }

    public class InteressiStudent : ICalcoloInteressi
    {
        public decimal CalcolaInteressi(decimal saldo)
        {
            return saldo * 0.01m;
        }

        public decimal Commissioni(Conto from, decimal importo)
        {
            if (importo < 20)
        {
            return 0;
        }
        else
        {
            return Math.Round(importo * 0.02m, 1);
        }
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
        public void Update(string evento)
        {
            Console.WriteLine($"[Log]: {evento}");
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

        public ICalcoloInteressi? CalcoloInteressi { get; set; } //in realtà ho dimenticato di usarlo

        private int _nextIdCliente = 1;
        private int _nextIdConto = 100;

        public int NuovoIdConto() => _nextIdConto++;
        public int NuovoIdCliente() => _nextIdCliente++;

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
        public string? Email { get; set; }

        public Cliente(int id, string? nome, string? email)
        {
            Id = id;
            Nome = nome;
            Email = email;
        }
    }
    #endregion

    #region Factory
    public abstract class Conto
    {
        public int Id { get; }
        public decimal Saldo { get; protected set; }
        public string? Tipo { get; set; }
        public int IdCliente { get; }
        

        public Conto(int id, string? tipo, int idCliente, decimal saldo = 0)
        {
            Id = id;
            Saldo = saldo;
            Tipo = tipo;
            IdCliente = idCliente;
        }

        public virtual void Deposita(decimal importo)
        {
            Saldo += importo;
        }

        public virtual bool Preleva(decimal importo)
        {
            if (Saldo < importo) return false;
            Saldo -= importo;
            return true;
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

    public static class ContoFactory
    {
        public static Conto Crea(string tipo, int idCliente)
        {
            var context = BankContext.GetIstance();
            int id = context.NuovoIdConto();
            switch (tipo.ToLower())
            {
                case "base":
                    return new ContoBase(id, idCliente);
                case "premium":
                    return new ContoPremium(id, idCliente);
                case "studente":
                    return new ContoStudente(id, idCliente);
                default:
                    return null;
            }
        }
    }
    #endregion

    #region Operazioni
    public class Operazione
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public string? TipoOperazione { get; set; }
        public decimal Importo { get; set; }
    }
    #endregion

    #region Servizio bancario
    public class ServizioBancario
    {
        private static BankContext _bankContext = BankContext.GetIstance();

        public static Cliente CreaCliente(string nome, string email)
        {
            int id = _bankContext.NuovoIdCliente();
            var cliente = new Cliente(id, nome, email);
            _bankContext.Clienti.Add(id, cliente);
            _bankContext.Notify($"Creato cliente: {nome}, con id: {id}");
            return cliente;
        }


        public static Conto CreaConto(int idCliente, string tipo)
        {
            var conto = ContoFactory.Crea(tipo, idCliente);
            _bankContext.Conti.Add(conto.Id, conto);
            _bankContext.Operazioni[conto.Id] = new List<Operazione>();
            _bankContext.Notify($"Creato conto di tipo: {conto.Tipo}, id: {conto.Id} per cliente: {idCliente}");
            return conto;
        }

        public static void Deposita(int idConto, decimal importo)
        {
            var conto = _bankContext.Conti[idConto];
            conto.Deposita(importo);
            _bankContext.Operazioni[idConto].Add(new Operazione { TipoOperazione = "Deposito", Importo = importo });
            _bankContext.Notify($"Deposito di {importo} su conto: {conto.Id}");
        }

        public static void Preleva(int idConto, decimal importo)
        {
            var conto = _bankContext.Conti[idConto];
            if (conto.Preleva(importo))
            {
                _bankContext.Operazioni[idConto].Add(new Operazione { TipoOperazione = "Prelievo", Importo = importo });
                _bankContext.Notify($"Prelievo di {importo} su conto: {conto.Id}");
            }
            else
            {
                _bankContext.Notify($"Impossibile prelevare {importo} su conto: {conto.Id}");
            }
        }

        public static void Trasferisci(int fromId, int toId, decimal importo)
        {
            var from = _bankContext.Conti[fromId];
            var to = _bankContext.Conti[toId];

            if (from.Preleva(importo))
            {
                to.Deposita(importo);
                _bankContext.Operazioni[fromId].Add(new Operazione { TipoOperazione = "Trasferimento", Importo = importo });
                _bankContext.Operazioni[toId].Add(new Operazione { TipoOperazione = "Trasferimento", Importo = importo }); ;
                _bankContext.Notify($"Trasferimento di {importo:C} da conto {fromId} a {toId}");
            }
            else
            {
                _bankContext.Notify($"Trasferimento fallito: saldo insufficiente su conto {fromId}");
            }
        }

        public static void MostraSaldi()
        {
            foreach (var c in _bankContext.Conti.Values)
            {
                Console.WriteLine($"Conto {c.Id} (Cliente {c.Id}) - Tipo: {c.Tipo}, Saldo: {c.Saldo:C}");
            }
        }
        public static void MostraOperazioni(int idConto)
        {
            if (!_bankContext.Operazioni.ContainsKey(idConto))
            {
                Console.WriteLine("Nessuna operazione trovata.");
                return;
            }
            foreach (var op in _bankContext.Operazioni[idConto])
            {
                Console.WriteLine($"{op.Date:g} - {op.TipoOperazione} - {op.Importo:C}");
            }
        }
    }


    #endregion
}