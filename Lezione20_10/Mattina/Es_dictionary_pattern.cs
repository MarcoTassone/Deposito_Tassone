using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione20_10.Mattina
{
    #region Singleton
    public sealed class BankContext
    {
        double Tassi;
        double Valute;
        string? Logger;
        string? Eventi;

        private static BankContext _istance;

        private BankContext() { }

        public static BankContext GetIstance()
        {
            if (_istance == null)
            {
                _istance = new BankContext();
            }
            return _istance;
        }
        private Dictionary<string, string> _configurazione = new Dictionary<string, string>();
    }
    #endregion

    public static class Conto
    {
        
    }
}