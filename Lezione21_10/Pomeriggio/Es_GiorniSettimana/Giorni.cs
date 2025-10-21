using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione21_10.Pomeriggio.Es_GiorniSettimana
{
    public class Giorni
    {
        public enum GiornoSettimana
        {
            Lunedi,
            Martedi,
            Mercoledi,
            Giovedi,
            Venerdi,
            Sabato,
            Domenica
        }

        public GiornoSettimana giornoSettimana;

        public void StampaGiorni()
        {
            switch (giornoSettimana)
            {
                case GiornoSettimana.Lunedi:
                    Console.WriteLine("Hai selezionato il giorno Lunedi");
                    break;
                case GiornoSettimana.Martedi:
                    Console.WriteLine("Hai selezionato il giorno Martedi");
                    break;
                case GiornoSettimana.Mercoledi:
                    Console.WriteLine("Hai selezionato il giorno Mercoledi");
                    break;
                case GiornoSettimana.Giovedi:
                    Console.WriteLine("Hai selezionato il giorno Giovedi");
                    break;
                case GiornoSettimana.Venerdi:
                    Console.WriteLine("Hai selezionato il giorno Venerdi");
                    break;
                case GiornoSettimana.Sabato:
                    Console.WriteLine("Hai selezionato il giorno Sabato");
                    break;
                case GiornoSettimana.Domenica:
                    Console.WriteLine("Hai selezionato il giorno Domenica"); 
                    break;
            }
        }
    }
}