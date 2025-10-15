using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione15_10.Mattina.Es_ObserverDP
{
    public class MobileApp : INewsSubscriber
    {
        public void Notifica(string news)
        {
            Console.WriteLine("Notification on mobile: " + news);
        }
    }
}