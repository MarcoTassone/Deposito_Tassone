using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace Lezione17_10.Pomeriggio
{
    public interface IObserver
    {
        void Aggiorna(string messaggio);
    }

    public class Logger : IObserver
    {
            public void Aggiorna(string messaggio)
        {
        Console.WriteLine($"Log: {messaggio}");
        
        }
    }
    public sealed class Utente
    {
        public int Id;
        private string? _username;
        private string? _email;
        public DateTime CreatedAt;
        public bool IsActive;

        public string Username
        {
            get { return _username; }
            set
            {
                if (_username != null)
                {
                    _username = value;
                }
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (_email != null)
                {
                    _email = value;
                }
            }
        }

        private Dictionary<int, Utente> _users;

        private Dictionary<int, List<ActionLog>> _actionByUsers;
        private Utente()
        {
            _users = new Dictionary<int, Utente>();
        }

        private static Utente _istance;

        public static Utente GetIstance()
        {
            if (_istance == null)
            {
                _istance = new Utente();
            }
            return _istance;
        }

        public void Imposta(int chiave, string valore)
        {
            if (_users.ContainsKey(chiave))
            {
                _users[chiave] = new Utente();
            }
            else
            {
                _users.Add(chiave, new Utente());
            }
        }

        public void Leggi(int chiave)
        {
            if (_users.ContainsKey(chiave))
            {
                Console.WriteLine(_users[chiave]);
            }
            else
            {
                Console.WriteLine($"La chiave non esiste.");
            }
        }

        public void StampaTutte()
        {
            foreach (var chiave in _users)
            {
                Console.WriteLine($"chiave: {chiave.Key}, azione: {chiave.Value}");
            }
        }

        public override string ToString()
        {
            return $"[{Id}]: {Username} - {Email} - {(IsActive ? "Attivo" : "Disattivo")} - Creato";
        }
    }

    public class ActionLog
    {
        public DateTime TimeStamp { get; set; }
        public string? ActionType { get; set; }
        public string? Metadata { get; set; }

        public override string ToString()
        {
                return $"{TimeStamp} - {ActionType} - {Metadata}";
        }
    }
}