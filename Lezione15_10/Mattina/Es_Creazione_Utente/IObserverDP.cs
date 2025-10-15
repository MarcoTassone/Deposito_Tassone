using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione15_10.Mattina.Es_Creazione_Utente
{
    public interface IObserverDP
    {
        void NotificaCreazione(string nomeUtente);
    }
}