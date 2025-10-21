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

    public class SMSNotifier : INotifierSMS
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Invio SMS: {message}");
        }
    }

    public class EmailNotifierSMS : INotifierSMS
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Invio email: {message}");
        }
    }

    public class AlertService
    {
        private readonly SMSNotifier _smsNotifier;
        public SMSNotifier SMSNotifier { get; set; }

        public void SendEmail(string text)
        {
            if (SMSNotifier == null)
            {
                Console.WriteLine($"Invio Email non riuscito.");
                return;
            }
            SMSNotifier.Notify(text);
        }

        public AlertService(SMSNotifier smsNotifier)
        {
            _smsNotifier = smsNotifier;
        }


        public void EmailAlert(string emailMessage)
        {
            SMSNotifier.Notify(emailMessage);
        }

        public void SendAlert(string message, INotifierSMS notifierSMS)
        {
            notifierSMS.Notify(message);
        }
    }
}