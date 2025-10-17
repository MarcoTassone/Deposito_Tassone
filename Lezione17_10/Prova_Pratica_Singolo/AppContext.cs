using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione17_10.Prova_Pratica_Singolo
{

    #region Interfacce

    public interface IStrategyPrezzi //strategy per calcolo prezzi
    {
        decimal CalcolaPrezzo(Product prodotto);
    }

    public interface IObserver //interfaccia observer
    {
        void Registra();
        void Rimuovi();
        void Notify();
    }

    public interface ISubscriber
    {
            void Update(string messagge);
    }
    #endregion

    #region SINGLETON
    public sealed class AppContext
    {
        private static AppContext _istanza;

        public decimal IVA { get; private set; } = .22m;
        public decimal scontiDiBase { get; private set; } = .10m;

        private List<IObserver> _observer = new List<IObserver>();


        private AppContext() { }
        public static AppContext GetIstanza()
        {
            if (_istanza == null)
            {
                _istanza = new AppContext();
            }
            return _istanza;
        }

        public void Log()
        {
            Console.WriteLine($"Benvenuto!");
        }
    }
    #endregion

    #region Factory method + classi concrete

    public abstract class Product
    {
        public string? Nome { get; protected set; }
        public decimal PrezzoBase { get; protected set; }

        public virtual decimal GetPrezzoBase() => PrezzoBase;
        public override string ToString()
        {
            return $"Nome: {Nome}, Prezzo: {PrezzoBase}";
        }
    }


    public class Skin : Product
    {
        public Skin()
        {
            Nome = "Skin";
            PrezzoBase = 10;
        }
    }

    public class Maglia : Product
    {
        public Maglia()
        {
            Nome = "Maglia";
            PrezzoBase = 10;
        }
    }

    public class Charm : Product
    {
        public Charm()
        {
            Nome = "Charm";
            PrezzoBase = 5;
        }
    }
    public static class ProductFactory
    {
        public static Product CreaProdotto(string tipo)
        {
            switch (tipo.ToLower())
            {
                case "skin":
                    return new Skin();
                case "charm":
                    return new Charm();
                case "maglia":
                    return new Charm();
                default:
                    return null;
            }
        }
    }
    #endregion

    #region Decorator + classi concrete
    public abstract class ProductDecorator : Product
    {
        private Product _product;

        public ProductDecorator(Product product)
        {
            _product = product;
        }
        public override decimal GetPrezzoBase()
        {
            return _product.GetPrezzoBase();
        }

        public override string ToString()
        {
            return $"{_product.Nome}";
        }
    }

    public class ConfezioneRegalo : ProductDecorator
    {
        public ConfezioneRegalo(Product product) : base(product)
        {
        }

        public override decimal GetPrezzoBase()
        {
            return base.GetPrezzoBase() + 2m;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, confezione regalo";
        }
    }

    public class StampaFrontere : ProductDecorator
    {
        public StampaFrontere(Product product) : base(product)
        {
        }

        public override decimal GetPrezzoBase()
        {
            return base.GetPrezzoBase() + 1m;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, stampa frontere";
        }
    }
    #endregion


    #region Classi concrete strategy
    public class StrategyPrezziStandard : IStrategyPrezzi
    {
        public decimal CalcolaPrezzo(Product prodotto)
        {
            return prodotto.GetPrezzoBase() * (1 + AppContext.GetIstanza().IVA);
        }
    }

    public class StrategyPrezziSconto : IStrategyPrezzi
    {
        public decimal CalcolaPrezzo(Product prodotto)
        {
            return prodotto.GetPrezzoBase() * (1 + AppContext.GetIstanza().IVA) * .30m;
        }
    }
    #endregion


    #region Observer + classi concrete
    public class Notifiche
    {
        private List<ISubscriber> _subscribers = new List<ISubscriber>();
        public void Registra(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }
        public void Notifica(string messaggio)
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(messaggio);
            }
        }
    }
    #endregion

}