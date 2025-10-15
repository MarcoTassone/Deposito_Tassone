using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione15_10.Mattina.Es_Creazione_Utente
{
    public static class UserFactory
    {
        public static Utente Crea(string nome)
        {
            return new Utente(nome);
        }
    }
}