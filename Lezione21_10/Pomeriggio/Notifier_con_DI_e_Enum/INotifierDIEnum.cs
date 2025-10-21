using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Lezione21_10.Pomeriggio.Notifier_con_DI_e_Enum.EmailNotifierDIEnum;

namespace Lezione21_10.Pomeriggio.Notifier_con_DI_e_Enum
{
    public interface INotifierDIEnum
    {
        void Invia(string messaggio);
    }

    public class EmailNotifierDIEnum : INotifierDIEnum
    {
        public void Invia(string messaggio)
        {
            {
                Console.WriteLine("Email inviata: " + messaggio);
            }
        }

        public class SmsNotifierDIEnum : INotifierDIEnum
        {
            public void Invia(string messaggio)
            {
                {
                    Console.WriteLine("SMS inviata: " + messaggio);
                }
            }
        }

        public class PushNotifierDIEnum : INotifierDIEnum
        {
            public void Invia(string messaggio)
            {
                {
                    Console.WriteLine("Notifica Push inviata: " + messaggio);
                }
            }
        }
    }

    public enum TipoNotifica
    {
        Email,
        Sms,
        Push
    }

    public static class NotifierFactory
    {
        public static INotifierDIEnum CreaNotifier(TipoNotifica tipo)
        {
            switch (tipo)
            {
                case TipoNotifica.Email:
                    return new EmailNotifierDIEnum();
                case TipoNotifica.Sms:
                    return new EmailNotifierDIEnum();
                case TipoNotifica.Push:
                    return new EmailNotifierDIEnum();
                default:
                    break;
                }
                return null;
        }
    }

    public class MessaggioService
    {
        private readonly INotifierDIEnum _notifierDIEnum;

        public MessaggioService(INotifierDIEnum notifierDIEnum)
        {
            _notifierDIEnum = notifierDIEnum;
        }

        public void Invia(INotifierDIEnum notifierDIEnum, string messaggio)
        {
            _notifierDIEnum.Invia(messaggio);
        }
    }
}