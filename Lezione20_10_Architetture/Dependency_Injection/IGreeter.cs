using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione20_10_Architetture.Dependency_Injection
{
    public interface IGreeter
    {
        void Greet(string message);
    }
    public class ConsoleGreeter : IGreeter
    {
        public void Greet(string message)
        {
            Console.WriteLine($"Messaggio: Ciao {message}, benvenuto!.");

        }
    }

    public class GreetingService
    {
        private readonly IGreeter _greeter;
        private readonly ILoggerGreet? _loggerGreet;

        public GreetingService(IGreeter greeter)
        {
            _greeter = greeter;
        }

        public GreetingService(IGreeter greeter, ILoggerGreet loggerGreet)
        {
            _greeter = greeter;
            _loggerGreet = loggerGreet;
        }

        public void Start(string message)
        {
            _greeter.Greet(message);
        }

        public void GreetAndLog(string message, string log)
        {
            _greeter.Greet(message);
            _loggerGreet?.Log(log);
        }
    }

    public interface ILoggerGreet
    {
        void Log(string message);
    }

    public class Logger : ILoggerGreet
    {
        public void Log(string message)
        {
            Console.WriteLine($"[Log]: {message}.");
        }
    }
}
