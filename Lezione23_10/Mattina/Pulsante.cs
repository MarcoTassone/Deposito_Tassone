using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione23_10.Mattina
{
    public class Pulsante
    {
        public event Action Premuto;

        public void SimulaClick()
        {
            Console.WriteLine($"Pulsante cliccato");
            Premuto?.Invoke();
        }
    }
}