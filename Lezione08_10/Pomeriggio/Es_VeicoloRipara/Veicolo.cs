using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione08_10.Pomeriggio.Es_VeicoloRipara
{
    public class Veicolo
    {
        public string Targa { get; }
        
        public Veicolo(string targa)
        {
            Targa = targa;
        }

        public virtual string Ripara()
        {
            return $"Il veicolo viene controllato";
        }
    }

    public class Auto : Veicolo
    {

        public Auto(string targa) : base(targa){ }
        public override string Ripara()
        {
            return $"Controllo olio, freni, motore dell'auto";
        }
    }

    public class Moto : Veicolo
    {
        public Moto(string targa) : base(targa){}
        public override string Ripara()
        {
            return $"Controllo catena, freni e gomme della moto";
        }
    }

    public class Camion : Veicolo
    {

        public Camion(string targa) : base(targa){}

        public override string Ripara()
        {
            return $"Controllo sospensioni, freni rinforzati, carico del camion";
        }
    }
}