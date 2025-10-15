using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione15_10.Mattina.Es_Creazione_Utente
{
    public class ModuloMarketing : IObserverDP
    {
        public void NotificaCreazione(string messaggio)
        {
            Console.WriteLine("Modulo Marketing - utente nome: " + messaggio + " creato.");
        }
    }
}