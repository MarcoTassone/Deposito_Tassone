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
        
        public static LoggerList Istanza{ get{ return _istanza;}}

        public static LoggerList GetIstanza()
        {
            if(_istanza == null)
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
            foreach(string log in _logs)
            {
                Console.WriteLine(log);
            }
        }
    }
}