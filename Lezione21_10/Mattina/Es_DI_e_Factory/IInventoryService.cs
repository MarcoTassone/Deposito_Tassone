using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Lezione21_10.Mattina.Es_DI_e_Factory
{
    #region DI
    public interface IInventoryService
    {
        void Stock();
    }

    public interface IPaymentProcessor
    {
        void Payment(decimal amount);
    }

    public interface IPricingStrategy
    {
        void Disocunt(decimal amount);
    }
    #endregion

    #region OrderService
    public class OrderService
    {
        public IPricingStrategy PricingStrategy { get; set; }

        public decimal Discount = .10m;
        private readonly IInventoryService _inventoryService;
        private readonly IPaymentProcessor _paymentProcessor;
        public void ScontoOrdine(decimal disocunt)
        {
            Discount = disocunt;
            if (PricingStrategy != null)
            {
                Console.WriteLine($"Non ci sono sconti.");
                return;
            }
            PricingStrategy.Disocunt(disocunt);
            Console.WriteLine($"Sconto del {disocunt}%");

        }

        public OrderService(IInventoryService inventory, IPaymentProcessor payment)
        {
            _inventoryService = inventory;
            _paymentProcessor = payment;
        }

        public void ProcessOrder(decimal amount)
        {
            Console.WriteLine($"Sono presenti {_inventoryService.Stock} e il loro prezzo è {amount}. Il pagamento è stato effettuato con {_paymentProcessor.Payment}");

        }
    }
    #endregion

    #region Factory
    public interface IProduct
    {
        void ProductCode();
    }

    public class DigitalBook : IProduct
    {
        public void ProductCode()
        {
            Console.WriteLine("Codice libro digitale.");
        }
    }

    public class PhysicalBook : IProduct
    {
        public void ProductCode()
        {
            Console.WriteLine("Codice libro fisico.");
        }
    }

    public abstract class ProductFactory
    {
        public static IProduct CreateProduct(string tipo)
        {
            switch (tipo.ToLower())
            {
                case "digitale":
                    return new DigitalBook();
                case "fisico":
                    return new PhysicalBook();
                default:
                    Console.WriteLine($"Tipo di libro non valido");
                    break;
            }
            return null;
        }


    }

    #endregion


}