using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione15_10.Mattina.Es_Observer
{
    public interface IObserver
    {
        void Aggiorna(string messaggio);
    }

    public interface ISoggetto
    {
        void Registra(IObserver observer);
        void Rimuovi(IObserver observer);
        void Notifica(string messaggio);
    }

    public class CentroMeteo : ISoggetto
    {
        private readonly List<IObserver> _osservatori = new List<IObserver>();

        public void AggiornaMeteo(string dati)
        {
            Console.WriteLine($"Meteo aggiornato.");
        }

        public void Registra(IObserver observer)
        {
            _osservatori.Add(observer);
        }

        public void Rimuovi(IObserver observer)
        {
            _osservatori.Remove(observer);
        }

        public void Notifica(string messaggio)
        {
            foreach (var observer in _osservatori)
            {
                observer.Aggiorna(messaggio);
            }
        }
    }

    public class DisplayConsole : IObserver
    {
        public void Aggiorna(string messaggio)
        {
            Console.WriteLine($"DisplayConsole: {messaggio}");
        }
    }

    public class DisplayMobile : IObserver
    {
        public void Aggiorna(string messaggio)
        {
            Console.WriteLine($"DisplayMobile: {messaggio}");
        }
    }
}