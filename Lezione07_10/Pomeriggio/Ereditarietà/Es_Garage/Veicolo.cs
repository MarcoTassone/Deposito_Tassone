using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione07_10.Pomeriggio.Ereditarietà.Es_Garage
{
    public class Veicolo
    {
        public string? Marca, Modello;


        public Veicolo(string marca, string modello)
        {
            Marca = marca;
            Modello = modello;
        }

        public override string ToString()
        {
            return $"Marca: {Marca}, Modello: {Modello}";
        }
    }

    public class Auto: Veicolo
    {
        public int NumeroPorte;

        public Auto(string marca, string modello, int numeroPorte) : base(marca, modello)
        {
            Marca = marca;
            Modello = modello;
            NumeroPorte = numeroPorte;
        }

    public override string ToString()
        {
            return base.ToString() + $", Numero porte: {NumeroPorte}";
        }

    }

    public class Moto : Veicolo
    {
        public string TipoManubrio;

        public Moto(string marca, string modello, string tipoManubrio) : base(marca, modello)
        {
            TipoManubrio = tipoManubrio;
        }

        public override string ToString()
        {
            return base.ToString() + $", Tipo manubrio: {TipoManubrio}";
        }
    }
}