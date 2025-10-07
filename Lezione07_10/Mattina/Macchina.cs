using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione07_10.Mattina
{
    public class Macchina
    {
        public string Motore;
        public float VelocitaMacchina;
        public int SospensioniMax;
        public int NrModifiche;

        public Macchina(string motore, float velocitaMacchina, int sospensioniMax, int nrModifiche)
        {
            Motore = motore;
            VelocitaMacchina = velocitaMacchina;
            SospensioniMax = sospensioniMax;
            NrModifiche = nrModifiche;
        }
    }
}