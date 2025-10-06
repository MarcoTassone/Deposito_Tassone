using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione06_10.Esempi
{
    public class MetodoHashCode
    {
        public string Nome;
        public double Prezzo;

    public override int GetHashCode()
    {
      return HashCode.Combine(Nome, Prezzo);
    }
    }
}