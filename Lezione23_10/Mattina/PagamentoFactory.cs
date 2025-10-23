using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione23_10.Mattina
{

    public interface ILoggerDelegate
    {
        void Log(string messaggio);
    }
    public interface IPagamento
    {
        string Paga(decimal importo);
    }

    public enum TipoPagamento
    {
        Carta,
        Paypal,
        Bonifico
    }

    public class PagamentoCarta : IPagamento
    {
        public string Paga(decimal importo)
        {
            string id = Guid.NewGuid().ToString();
            Console.WriteLine($"Pagamento di {importo} euro con carta completato.");
            return id;
        }
    }

    public class PagamentoPaypal : IPagamento
    {
        public string Paga(decimal importo)
        {
            string id = Guid.NewGuid().ToString();
            Console.WriteLine($"Pagamento di {importo} euro con paypal completato.");
            return id;
        }
    }

    public class PagamentoBonifico : IPagamento
    {
        public string Paga(decimal importo)
        {
            string id = Guid.NewGuid().ToString();
            Console.WriteLine($"Pagamento di {importo} euro con bonifico completato.");
            return id;
        }
    }

    public class ConsoleLoggerDelegate : ILoggerDelegate
    {
        public void Log(string messaggio)
        {
            Console.WriteLine($"[LOG] {messaggio}");
        }
    }

    public static class PagamentoFactory
    {
        public static IPagamento Pagamento(TipoPagamento tipo)
        {
            switch (tipo)
            {
                case TipoPagamento.Carta:
                    return new PagamentoCarta();
                case TipoPagamento.Paypal:
                    return new PagamentoPaypal();
                case TipoPagamento.Bonifico:
                    return new PagamentoBonifico();
                default:
                    return null;
            }
        }
    }

    public class PaymentService
    {
        private readonly IPagamento _pagamento;
        private readonly ILoggerDelegate _logger;
        public event PagamentoCompletatoHandler OnPagamentoCompletato;

        public PaymentService(IPagamento pagamento, ILoggerDelegate logger)
        {
            _pagamento = pagamento;
            _logger = logger;
        }
        
        public void ProcessaPagamento(decimal importo)
        {
            string id = _pagamento.Paga(importo);
            
            _logger.Log($"Pagamento di {importo} euro completato. ID: {id}");
            OnPagamentoCompletato?.Invoke(id, importo);
        }
    }
}