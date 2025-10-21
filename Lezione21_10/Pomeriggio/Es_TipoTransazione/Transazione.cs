using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lezione21_10.Pomeriggio.Es_TipoTransazione
{
    public class Transazione
    {
        public enum TipoTransazione
        {
            Acquisto,
            Rimborso,
            Trasferimento
        }

        public TipoTransazione tipoTransazione;
        public decimal Importo;

        public void Transaction(decimal importo)
        {
            Importo = importo;
            switch (tipoTransazione)
            {
                case TipoTransazione.Acquisto:
                    Console.WriteLine($"Acquisto di {Importo} euro");
                    break;
                case TipoTransazione.Rimborso:
                    Console.WriteLine($"Rimborso di {Importo} euro");
                    break;
                case TipoTransazione.Trasferimento:
                    Console.WriteLine($"Trasferimento di {Importo} euro");
                    break;
            }
        }
    }
}