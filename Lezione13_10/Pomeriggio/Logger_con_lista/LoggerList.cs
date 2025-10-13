using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione13_10.Pomeriggio.Logger_con_lista
{
    public sealed class LoggerList
    {
        private static LoggerList _istanza = new LoggerList();

        private List<string> _logs = new List<string>();
        private LoggerList()
        {

        }

        public static LoggerList Istanza { get { return _istanza; } }

        public static LoggerList GetIstanza()
        {
            if (_istanza == null)
            {
                _istanza = new LoggerList();
            }
            return _istanza;
        }

        public void Log(string messaggio)
        {
            _logs.Add(messaggio);
        }

        public void StampaLog()
        {
            foreach (string log in _logs)
            {
                Console.WriteLine(log);
            }
        }
    }

    public sealed class LoggerEventi
    {
        private static LoggerEventi _istanza = new LoggerEventi();

        private List<string> _logsEventi = new List<string>();
        private LoggerEventi()
        {

        }

        public static LoggerEventi Istanza { get { return _istanza; } }

        public static LoggerEventi GetIstanza()
        {
            if (_istanza == null)
            {
                _istanza = new LoggerEventi();
            }
            return _istanza;
        }

        public void Log(string messaggio)
        {
            _logsEventi.Add($"Eseguito evento: {messaggio}");
        }

        public void StampaLog()
        {
            foreach (string log in _logsEventi)
            {
                Console.WriteLine(log);
            }
        }
    }
    
    public sealed class LoggerErrore
    {
        private static LoggerErrore _istanza = new LoggerErrore();

        private List<string> _logsErrore = new List<string>();
        private LoggerErrore()
        {

        }

        public static LoggerErrore Istanza { get { return _istanza; } }

        public static LoggerErrore GetIstanza()
        {
            if (_istanza == null)
            {
                _istanza = new LoggerErrore();
            }
            return _istanza;
        }

        public void Log(string messaggio)
        {
            _logsErrore.Add($"ERRORE: {messaggio}");
        }

        public void StampaLog()
        {
            foreach (string log in _logsErrore)
            {
                Console.WriteLine(log);
            }
        }
    }
}