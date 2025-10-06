using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione06_10.Esempi
{
    public class MetodoEquals
    {
        public int X;
        public int Y;

        public override bool Equals(object obj)
        {
            if (obj is MetodoEquals altro)
            {
                return this.X == altro.X && this.Y == altro.Y;
            }
            return false;
        }
    }
}