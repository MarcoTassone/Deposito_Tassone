using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Lezione20_10_Architetture.Dependency_Injection
{
    public sealed class AppConfig
    {
        private static AppConfig _istance;

        public static AppConfig Istance()
        {
            if (_istance == null)
            {
                _istance = new AppConfig();
            }
            return _istance;
        }

        public string? NomeApp { get; private set; }
        public string? Valuta { get; private set; }
        public decimal IVA { get; private set; }

        private AppConfig()
        {
            NomeApp = "Ordini";
            Valuta = "EUR";
            IVA = 0.22m;
        }
    }

    public interface ILoggerApp
    {
        void State(string message);
    }

    public class LoggerService : ILoggerApp
    {
        private readonly AppConfig _appConfig;

        public LoggerService(AppConfig appConfig)
        {
            _appConfig = appConfig;
        }

        public void State(string message)
        {
            Console.WriteLine($"{_appConfig.NomeApp} - {message}");
        }
    }

    public class OrderService
    {
        private readonly ILoggerApp _loggerApp;
        public OrderService(ILoggerApp loggerApp)
        {
            _loggerApp = loggerApp;
        }

        private int _nextId = 1;

        public void CreaOrdine(string prodotto, decimal prezzo)
        {
            int ordineId = _nextId++;
            _loggerApp.State($"Ordine {ordineId} creato per {prodotto} - prezzo: {prezzo}");
        }
    }
}