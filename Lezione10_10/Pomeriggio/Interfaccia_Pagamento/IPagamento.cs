using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione10_10.Pomeriggio.Interfaccia_Pagamento
{
    public interface IPagamento
    {
        void EseguiPagamento(decimal importo);
        void MostraPagamento();
    }

    public class PagamentoCarta : IPagamento
    {

        public string? Circuito { get; set; }

        public PagamentoCarta(string? circuito) => Circuito = circuito;

        public void EseguiPagamento(decimal importo)
        {
            Console.WriteLine($"Pagamento di {importo} euro con carta {Circuito}");
        }

        public void MostraPagamento()
        {
            Console.WriteLine("Metodo: Carta di credito");
        }
    }

    public class PagamentoContanti : IPagamento
    {

        public void EseguiPagamento(decimal importo)
        {
            Console.WriteLine($"Pagamento di {importo} euro in contanti");
        }

        public void MostraPagamento()
        {
            Console.WriteLine("Metodo: Contanti");
        }
    }

    public class PagamentoPayPal : IPagamento
    {

        private string? _emailUtente;

        public string? EmailUtente
        {
            get => _emailUtente; set
            {
                if (value != " ")
                {

                    _emailUtente = value;
                }

            }
        }

        public PagamentoPayPal(string? emailUtente) => EmailUtente = emailUtente;

        public void EseguiPagamento(decimal importo)
        {
            Console.WriteLine($"Pagamento di {importo} euro tramite PayPal di: {EmailUtente}");
        }

        public void MostraPagamento()
        {
            Console.WriteLine("Metodo: PayPal");
        }
    }
}