using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Lezione13_10.Pomeriggio.Logger
{
    public sealed class Logger
    {
        private static Logger _istanza = new Logger();

        private Logger()
        {
        
        }

        public static Logger GetIstanza()
        {
            if(_istanza == null)
            {
                _istanza = new Logger();
            }
            return _istanza;
        }
        
        public static void ScriviMessaggio(string messaggio)
        {
            Console.WriteLine(DateTime.Now + " " + messaggio);
        }
    }
}