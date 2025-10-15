using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione15_10.Mattina.Es_ObserverDP
{
    public interface INewsSubscriber
    {
        void Notifica(string messaggio);
    }
}