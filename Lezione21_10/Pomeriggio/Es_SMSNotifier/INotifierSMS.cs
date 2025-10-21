using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione21_10.Pomeriggio.Es_SMSNotifier
{
    public interface INotifierSMS
    {
        void Notify(string message);
    }

    public interface ILoggerSMS
    {
        void Log(string message);
    }

    public class SMSNotifier : INotifierSMS
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Invio SMS: {message}");
        }
    }

    public class LoggerSMS : ILoggerSMS
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }

    public class AlertService
    {
        private readonly ILoggerSMS _loggerSMS;

        public AlertService(ILoggerSMS loggerSMS)
        {
            _loggerSMS = loggerSMS;
        }

        public void SendAlert(string message, INotifierSMS notifierSMS)
        {
            notifierSMS.Notify(message);
            _loggerSMS.Log(DateTime.Now.ToString(""));
        }
    }
}