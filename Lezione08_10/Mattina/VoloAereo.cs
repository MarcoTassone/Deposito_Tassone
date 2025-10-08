using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione08_10.Mattina
{
    public class VoloAereo
    {
        private int PostiOccupati;
        public const int MAX_POSTI = 150;
        public string CodiceVolo { get; set; }
        
        public int postiOccupati => PostiOccupati;

        public int PostiLiberi => MAX_POSTI - postiOccupati; 

        public VoloAereo(string codiceVolo)
        {
            PostiOccupati = 0;
            CodiceVolo = codiceVolo;
        }

        public void EffettuaPrenotzione(int numeroPosti)
        {
            if (numeroPosti <= PostiLiberi)
            PostiOccupati += numeroPosti;
        }

        public void AnnullaPrenotazione(int numeroPosti)
        {
            if (numeroPosti <= PostiOccupati)
            PostiOccupati -= numeroPosti;
        }

        public void VisualizzaStato()
        {
            Console.WriteLine($"Codice volo: {CodiceVolo}, Posti liberi: {PostiLiberi}, Posti occupati: {postiOccupati}");
        }
    }
}