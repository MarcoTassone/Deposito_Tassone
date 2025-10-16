using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione16_10.Mattina.StrategiaOperazione
{
    #region Singleton class Utente
    public sealed class Utente
    {
        private static Utente _instance;
        private Utente(){}

        // Punto di accesso globale all’istanza
        public static Utente GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Utente();
            }
            return _instance;
        }
    }
    #endregion

    #region Interfaccia
    public interface IStrategiaOperazione
    {
        double Calcola(double a, double b);
    }
    #endregion

    #region Classi concrete che implementano l'interfaccia
    public class SommaStrategia : IStrategiaOperazione
    {
        public double Calcola(double a, double b)
        {
            return a + b;
        }
    }

    public class SottrazioneStrategia : IStrategiaOperazione
    {
        public double Calcola(double a, double b)
        {
            return a - b;
        }
    }

    public class MoltiplicazioneStrategia : IStrategiaOperazione
    {
        public double Calcola(double a, double b)
        {
            return a * b;
        }
    }

    public class DivisioneStrategia : IStrategiaOperazione
    {
        public double Calcola(double a, double b)
        {
            return a / b;
        }
    }
    #endregion

    #region Calcolatrice
    public class Calcolatrice
    {
        private IStrategiaOperazione _strategiaOperazione;

        public void EseguiOperazione(double a, double b)
        {
            if (_strategiaOperazione == null)
            {
                Console.WriteLine("Nessuna strategia impostata.");
                return;
            }
            double result = _strategiaOperazione.Calcola(a, b);
            Console.WriteLine($"Risultato operazione: {result}");

        }

        public void ImpostaStrategia(IStrategiaOperazione strategiaOperazione)
        {
            _strategiaOperazione = strategiaOperazione;
        }
    }
    #endregion
}
