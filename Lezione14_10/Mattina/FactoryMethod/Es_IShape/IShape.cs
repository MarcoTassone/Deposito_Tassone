using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione14_10.Mattina.FactoryMethod.Es_IShape
{
    public interface IShape
    {
        void Draw();
    }

    public class ConcreteCircle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Disegnando un cerchio.");
        }
    }

    public class ConcreteSquare : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Disegnando un quadrato.");
        }
    }

    public abstract class ShapeCreator
    {
        public static IShape CreateShape(string tipo)
        {
            switch (tipo.ToLower())
            {
                case "cerchio":
                    new ConcreteCircle().Draw();
                    break;
                case "quadrato":
                    new ConcreteSquare().Draw();
                    break;
                default:
                    Console.WriteLine($"Forma non valida.");
                    break;
            }
            return null;
        }
    }
}