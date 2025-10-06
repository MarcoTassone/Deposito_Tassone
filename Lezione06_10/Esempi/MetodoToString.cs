using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione06_10.Esempi
{
    public class MetodoToString
    {
        public string Nome;
        public int Eta;

        public override string ToString()
        {
            return $"Nome: {Nome}, Eta: {Eta}";
        }
    }
}