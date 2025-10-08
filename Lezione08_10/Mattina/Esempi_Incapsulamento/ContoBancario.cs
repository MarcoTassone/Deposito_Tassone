using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione08_10.Mattina.Esempi_Incapsulamento
{
    public class ContoBancario
    {
        private double saldo;
        private string? _Nome { get; set; }

        public string nome
        {
            get { return _Nome; }
        }

        public void NuovoSaldo(double nuovoSaldo)
        {
            if (nuovoSaldo > 0)
            {
                saldo += nuovoSaldo;
            }
        }

        public double Saldo
        {
            get { return saldo; }
            set
            {
                if (value >= 0)
                {
                    saldo = value;
                }
            }
        }
    }
}