using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione15_10.Mattina.Es_ObserverDP
{
    public sealed class NewsAgency
    {
        private static NewsAgency _istanza = new NewsAgency();

        private List<INewsSubscriber> _subscriberList = new List<INewsSubscriber>();
        private NewsAgency() { }

        public static NewsAgency GetInstance()
        {
            if (_istanza == null)
            {
                _istanza = new NewsAgency();
            }
            return _istanza;
        }

        public void AddSubscriber(INewsSubscriber subscriber)
        {
            _subscriberList.Add(subscriber);
        }

        public void Notify(string messaggio)
        {
            foreach (var subscriber in _subscriberList)
            {
                subscriber.Notifica(messaggio);
            }
        }
    }
}