using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lezione16_10.Mattina.StrategiaOperazione;

namespace Lezione16_10.Mattina.StrategiaPiatti
{
    #region Interfacce
    public interface IPiatto
    {
        string Descrizione();
        string Prepara();
    }

    public interface IPreparazioneStrategia
    {
        string Prepara(string descrizione);
    }
    #endregion

    #region Classi concrete che implementano IPiatto
    public class Pizza : IPiatto
    {
        public string Descrizione()
        {
            return "Pizza";
        }
        public string Prepara()
        {
            return "Preparazione Pizza";
        }
    }

    public class Hamburger : IPiatto
    {
        public string Descrizione()
        {
            return "Hamburger";
        }
        public string Prepara()
        {
            return "Preparazione Hamburger";
        }
    }

    public class Insalata : IPiatto
    {
        public string Descrizione()
        {
            return "Insalata";
        }
        public string Prepara()
        {
            return "Preparazione Insalata";
        }
    }
    #endregion

    #region Decorator
    public abstract class IngredienteExtra : IPiatto
    {
        protected IPiatto _piatto;
        public IngredienteExtra(IPiatto piatto)
        {
            _piatto = piatto;
        }

        public string Descrizione()
        {
            return $"{_piatto.Descrizione()}";
        }

        public string Prepara()
        {
            return $"{_piatto.Prepara()}";
        }
    }
    #endregion

    #region Concrete Decorator
    public class ConFormaggio : IngredienteExtra
    {
        public ConFormaggio(IPiatto basePiatto) : base(basePiatto)
        {
            Console.WriteLine($"{basePiatto.Descrizione()} + formaggio");
        }
    }

    public class ConPomodori : IngredienteExtra
    {
        public ConPomodori(IPiatto basePiatto) : base(basePiatto)
        {
            Console.WriteLine($"{basePiatto.Descrizione()} + pomodori");
        }
    }

    public class ConMaionese : IngredienteExtra
    {
        public ConMaionese(IPiatto basePiatto) : base(basePiatto)
        {
            Console.WriteLine($"{basePiatto.Descrizione()} + maionese");
        }
    }
    #endregion

    #region Factory method
    public static class PiattoFactory
    {
        public static IPiatto Crea(string tipo)
        {
            switch (tipo.ToLower())
            {
                case "pizza":
                    return new Pizza();
                case "vaniglia":
                    return new Hamburger();
                case "frutta":
                    return new Insalata();
                default:
                    return null;
            }
        }
    }
    #endregion

    #region Strategie concrete
    public class Fritto : IPreparazioneStrategia
    {
        public string Prepara(string descrizione)
        {
            return $"{descrizione} fritto";
        }
    }

    public class AlForno : IPreparazioneStrategia
    {
        public string Prepara(string descrizione)
        {
            return $"{descrizione} al forno";
        }
    }

    public class AllaGriglia : IPreparazioneStrategia
    {
        public string Prepara(string descrizione)
        {
            return $"{descrizione} alla griglia";
        }
    }
    #endregion

    #region Context
    public class Chef
    {
        private IPreparazioneStrategia _strategia;
        public string Prepara(IPiatto piatto)
        {
        return _strategia.Prepara(piatto.Descrizione());
        }
    }
    #endregion

}