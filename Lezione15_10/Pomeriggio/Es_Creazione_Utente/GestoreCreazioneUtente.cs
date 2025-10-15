using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione15_10.Mattina.Es_Creazione_Utente
{
    public sealed class GestoreCreazioneUtente : ISoggettoDP
    {
        private static GestoreCreazioneUtente _instance = new GestoreCreazioneUtente();

        public static GestoreCreazioneUtente GetInstatnce()
        {
            if (_instance == null)
            {
                _instance = new GestoreCreazioneUtente();
            }
            return _instance;
        }
        private List<IObserverDP> _observers = new List<IObserverDP>();

        public void CreaUtente(string nome)
        {
            Utente utente = UserFactory.Crea(nome);
            utente.ToString();
            Notifica(nome);
        }

        public void Registra(IObserverDP observer)
        {
            _observers.Add(observer);
        }

        public void Rimuovi(IObserverDP observer)
        {
            _observers.Remove(observer);
        }

        public void Notifica(string messaggio)
        {
            foreach (var observer in _observers)
            {
                observer.NotificaCreazione(messaggio);
            }
        }
    }
}