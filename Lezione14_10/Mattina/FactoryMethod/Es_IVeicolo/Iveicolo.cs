using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Lezione14_10.Mattina.FactoryMethod.Es_IVeicolo
{
    public interface INavi
    {
        void Avvia();
        void MostraTipo();
    }

    public interface Iveicolo
    {
        void Avvia();
        void MostraTipo();
    }

    public class ConcreteYacht : INavi
    {
        public void Avvia()
        {
            Console.WriteLine("Avvio della nave.");
        }

        public void MostraTipo()
        {
            Console.WriteLine("Tipo: Yacht.");
        }
    }

    public class ConcreteVeliero : INavi
    {
        public void Avvia()
        {
            Console.WriteLine("Avvio del Veliero.");
        }

        public void MostraTipo()
        {
            Console.WriteLine("Tipo: Veliero.");
        }
    }

    public class Piroscafo : INavi
    {
        public void Avvia()
        {
            Console.WriteLine("Avvio del Piroscafo.");
        }

        public void MostraTipo()
        {
            Console.WriteLine("Tipo: Piroscafo.");
        }
    }

    public class ConcreteVeicoloAuto : Iveicolo
    {
        public void Avvia()
        {
            Console.WriteLine("Avvio dell'auto.");
        }

        public void MostraTipo()
        {
            Console.WriteLine("Tipo: Auto.");
        }
    }

    public class ConcreteVeicoloMoto : Iveicolo
    {
        public void Avvia()
        {
            Console.WriteLine("Avvio della moto.");
        }

        public void MostraTipo()
        {
            Console.WriteLine("Tipo: Moto.");
        }
    }

    public class ConcreteVeicoloCamion : Iveicolo
    {
        public void Avvia()
        {
            Console.WriteLine("Avvio del camion.");
        }

        public void MostraTipo()
        {
            Console.WriteLine("Tipo: Camion.");
        }
    }

    public abstract class VeicoloFactory
    {

        public abstract Iveicolo FactoryMethod();

        public void AvviaVeicolo()
        {
            Iveicolo veicolo = FactoryMethod();
            veicolo.Avvia();
        }

        public void MostraTipoVeicolo()
        {
            Iveicolo veicolo = FactoryMethod();
            veicolo.MostraTipo();
        }

        /// <summary>Senza classe abstract</summary>
        // public static Iveicolo CreateVeicolo(string tipo)
        // {
        //     switch (tipo.ToLower())
        //     {
        //         case "auto":
        //             return new ConcreteVeicoloAuto();
        //         case "moto":
        //             return new ConcreteVeicoloMoto();
        //         case "camion":
        //             return new ConcreteVeicoloCamion();
        //         default:
        //             Console.WriteLine($"Tipo di veicolo non valido");
        //             break;
        //     }
        //     return null;
        // }
    }

    public abstract class NaveFactory
    {
        public abstract INavi FactoryMethod();

        public void AvviaNave()
        {
            INavi nave = FactoryMethod();
            nave.Avvia();
        }

        public void MostraTipoNave()
        {
            INavi nave = FactoryMethod();
            nave.MostraTipo();
        }
    }

    public class CreatorNaveFactoryVeliero : NaveFactory
    {
        public override INavi FactoryMethod()
        {
            return new ConcreteVeliero();
        }
    }

    public class CreatorNaveFactoryYacht : NaveFactory
    {
        public override INavi FactoryMethod()
        {
            return new ConcreteYacht();
        }
    }

    public class CreatorNaveFactoryPiroscafo : NaveFactory
    {
        public override INavi FactoryMethod()
        {
            return new Piroscafo();
        }
    }

    public class CreatorVeicoloFactoryAuto : VeicoloFactory
    {
        public override Iveicolo FactoryMethod()
        {
            return new ConcreteVeicoloAuto();
        }
    }

    public class CreatorVeicoloFactoryMoto : VeicoloFactory
    {
        public override Iveicolo FactoryMethod()
        {
            return new ConcreteVeicoloMoto();
        }
    }

    public class CreatorVeicoloFactoryCamion : VeicoloFactory
    {
        public override Iveicolo FactoryMethod()
        {
            return new ConcreteVeicoloCamion();
        }
    }
}