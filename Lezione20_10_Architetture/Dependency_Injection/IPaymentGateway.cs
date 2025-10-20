using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione20_10_Architetture.Dependency_Injection
{
    public interface IPaymentGateway
    {
        void Paga(double importo);
    }


    public class PaypalGateway : IPaymentGateway
    {
        public void Paga(double importo)
        {
            Console.WriteLine($"Hai pagato {importo} con metodo Paypal");

        }
    }

    public class StripeGateway : IPaymentGateway
    {
        public void Paga(double importo)
        {
            Console.WriteLine($"Hai pagato {importo} con metodo Stripe");

        }
    }

    public class PaymentProcessor
    {
        private readonly IPaymentGateway _paymentGateway;

        public PaymentProcessor(IPaymentGateway paymentGateway)
        {
            _paymentGateway = paymentGateway;
        }

        public void Paga(double importo)
        {
            _paymentGateway.Paga(importo);
        }
    }
}