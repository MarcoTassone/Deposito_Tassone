using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione15_10.Mattina
{
    public interface Esempio_Observer
    {
        void Update(int newState);
    }

    // 2. Subject: interfaccia che permette di aggiungere/rimuovere observer e notificare
    public interface ISubject
    {
        void Attach(Esempio_Observer observer);
        void Detach(Esempio_Observer observer);
        void Notify();
    }

    // 3. ConcreteSubject: implementa ISubject e mantiene lo stato osservato
    public class ConcreteSubject : Esempio_Observer
    {
        private readonly List<Esempio_Observer> _observers = new List<Esempio_Observer>();
        private int _state;

        // Proprietà dello stato; quando cambia, notifica gli observer
        public int State
        {
            get => _state;
            set
            {
                _state = value;
                Notify();
            }
        }

        public void Attach(Esempio_Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Esempio_Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_state);
            }
        }

        public void Update(int newState)
        {
            throw new NotImplementedException();
        }
    }

    // 4. ConcreteObserver: implementa la logica di reazione alla notifica
    public class ConcreteObserver : Esempio_Observer
    {
        private readonly string _name;
        private int _observerState;

        public ConcreteObserver(string name)
        {
            _name = name;
        }

        // Viene chiamato dal Subject con il nuovo stato
        public void Update(int newState)
        {
            _observerState = newState;
            Console.WriteLine($"{_name} ha ricevuto aggiornamento, stato = {_observerState}");
        }
    }
}