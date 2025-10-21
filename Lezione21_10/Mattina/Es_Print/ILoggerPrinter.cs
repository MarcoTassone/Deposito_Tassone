using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione21_10.Mattina.Es_Print
{
    public interface ILoggerPrinter
    {
        void Log();
    }

    public class LoggerP : ILoggerPrinter
    {
        public void Log()
        {
            Console.WriteLine($"Connessione con la stampante stabilita.");
        }
        
    }

    public class Printer
    {
        public ILoggerPrinter LoggerPrinter { get; set; }
        public void Print()
        {
            if (LoggerPrinter == null)
            {
                Console.WriteLine($"Stampante non impostata.");
                return;
            }

            LoggerPrinter.Log();
            Console.WriteLine($"Stampa in corso...");
            
        }
    }
    

}