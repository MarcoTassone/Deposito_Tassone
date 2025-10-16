using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione15_10.Pomeriggio.ES_Decorator
{
    public interface ITorta
    {
        string Descrizione();
    }

    public class TortaCioccolato : ITorta
    {
        public string Descrizione() => "Torta al cioccolato";
    }

    public class TortaVaniglia : ITorta
    {
        public string Descrizione() => "Torta alla vaniglia";
    }

    public class TortaFrutta : ITorta
    {
        public string Descrizione() => "Torta alla frutta";
    }


    public abstract class DecoratoreTorta : ITorta
    {
        protected ITorta _baseTorta;

        public DecoratoreTorta(ITorta baseTorta)
        {
            _baseTorta = baseTorta;
        }

        public virtual string Descrizione()
        {
            return $"{_baseTorta.Descrizione()}";
        }
    }

    public class ConPannaTorta : DecoratoreTorta
    {
        public ConPannaTorta(ITorta baseTorta) : base(baseTorta)
        {
            Console.WriteLine($"{baseTorta.Descrizione()} + panna");
            
        }
    }

    public class ConFragoleTorta : DecoratoreTorta
    {
        public ConFragoleTorta(ITorta baseTorta) : base(baseTorta)
        {
            Console.WriteLine($"{baseTorta.Descrizione()} + fragole");
        }
    }
    
    public class ConGlassaTorta : DecoratoreTorta
    {
        public ConGlassaTorta(ITorta baseTorta) : base(baseTorta)
        {
            Console.WriteLine($"{baseTorta.Descrizione()} + glassa");
        }
    }

    public static class TortaFactory
    {
        public static ITorta CreaTortaBase(string tipo)
        {
            switch (tipo)
            {
                case "cioccolato":
                    return new TortaCioccolato();
                case "vaniglia":
                    return new TortaVaniglia();
                case "frutta":
                    return new TortaFrutta();
                default:
                    return null;
            }
        }
    }
}