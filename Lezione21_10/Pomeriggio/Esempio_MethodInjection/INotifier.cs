using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione21_10.Pomeriggio.Esempio_MethodInjection
{
    public interface INotifier
    {
        void Notify(string message);
    }

    public class EmailNotifier : INotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Invio email: {message}");
        }
    }

    public class NotificationService
    {
        public void SendNotification(string user, INotifier notifier)
        {
            notifier.Notify($"Ciao {user}, hai una nuova notifica!");
        }
    }
}