using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione08_10.Mattina.PrenotazioneViaggio
{
    public class PrenotazioneViaggio
    {
        private int postiPrenotati;
        public int maxPosti = 20;
        // public List<string> Destinazione { get; set; } = new List<string>();

        public string Destinazione { get; set; }

        public int PostiPrenotati { get { return postiPrenotati; } }

        // public PrenotazioneViaggio(int prenotati)
        // {
        //     postiPrenotati = prenotati;
        // }

        public int PostiDisponibili
        {
            get { return maxPosti - postiPrenotati; }
        }

        public void PrenotaPosti(int numeroPosti)
        {
            if (numeroPosti <= PostiDisponibili)
            {
                postiPrenotati += numeroPosti;
                Console.WriteLine($"Hai effettuato una prenotazione di {numeroPosti} posti.");

            }
            else
            {
                Console.WriteLine($"Hai inserito {numeroPosti} posti, ma ci sono solo {PostiDisponibili} disponibili.");

            }
        }

        public void AnnullaPrenotazione(int numeroPosti)
        {
            if (PostiPrenotati > 0)
            {
                postiPrenotati -= numeroPosti;
                Console.WriteLine($"Prenotazione annullata.");

            }
            else
            {
                Console.WriteLine($"Non hai effettuato nessuna prenotazione.");

            }
        }

        public void VisualizzaStato()
        {
            Console.WriteLine($"Posti prenotati: {postiPrenotati}, Posti disponibili: {PostiDisponibili}");
        }

    }
    public class Persona : PrenotazioneViaggio
    {
        public string? Nome { get; set; }


        public Persona(string nome) : base()
        {
                Nome = nome;
        }
    }
}
