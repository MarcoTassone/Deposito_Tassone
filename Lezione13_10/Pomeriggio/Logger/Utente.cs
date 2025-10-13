using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione13_10.Pomeriggio.Logger
{
    public class Utente
    {
        public string? Nome { get; set; }

        public Utente(string? nome)
        {
            Nome = nome;
        }

        public void Azione(string? azione)
        {
            Logger logger = Logger.GetIstanza();
            logger.ScriviMessaggio($"Utente {Nome} ha eseguito l'azione {azione}");
        }
    }
}