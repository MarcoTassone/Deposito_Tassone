using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione15_10.Pomeriggio.ES_Decorator
{
    #region Interfaccia + classi concrete
    public interface IBevanda //interfaccia 
    {
        string Descrizione();
        double Costo();
    }

    public class Caffe : IBevanda
    {
        public string Descrizione() => "Caffe";
        public double Costo() => 0.99;
    }

    public class Te : IBevanda
    {
        public string Descrizione() => "Te";
        public double Costo() => 1.99;
    }
    #endregion


    #region Decorator abstract con implementazione di interfaccia IBevanda
    public abstract class DecoratoreBevanda : IBevanda
    {
        protected IBevanda _bevanda;

        public DecoratoreBevanda(IBevanda bevanda)
        {
            _bevanda = bevanda;
        }

        public virtual string Descrizione() => _bevanda.Descrizione();
        public virtual double Costo() => _bevanda.Costo();
    }
    #endregion


    #region Classi concrete decoratrici
    public class ConLatte : DecoratoreBevanda
    {
        public ConLatte(IBevanda bevanda) : base(bevanda) { }
        public override string Descrizione() => $"[ConLatte] {_bevanda.Descrizione()}, latte";
        public override double Costo() => _bevanda.Costo() + 1.50;
    }

    public class ConCioccolato : DecoratoreBevanda
    {
        public ConCioccolato(IBevanda bevanda) : base(bevanda) { }
        public override string Descrizione() => $"[ConCioccolato] {_bevanda.Descrizione()}, cioccolato";
        public override double Costo() => _bevanda.Costo() + 1.20;
    }

    public class ConPanna : DecoratoreBevanda
    {
        public ConPanna(IBevanda bevanda) : base(bevanda) { }
        public override string Descrizione() => $"[ConPanna] {_bevanda.Descrizione()}, panna";
        public override double Costo() => _bevanda.Costo() + 1.30;
    }
    #endregion
}