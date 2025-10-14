using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione14_10.Mattina.FactoryMethod
{
    public interface IProduct
    {
        void Operation();
    }

    // 2. ConcreteProductA: implementa IProduct
    public class ConcreteProductA : IProduct
    {
        public void Operation()
        {
            Console.WriteLine("Esecuzione di ConcreteProductA.Operation()");
        }
    }

    // 3. ConcreteProductB: un altro prodotto concreto
    public class ConcreteProductB : IProduct
    {
        public void Operation()
        {
            Console.WriteLine("Esecuzione di ConcreteProductB.Operation()");
        }
    }

    // 4. Creator: dichiara il Factory Method
    public abstract class Creator
    {
        // Factory Method: restituisce un IProduct
        public abstract IProduct FactoryMethod();

        // Un metodo del creator che utilizza il prodotto
        public void AnOperation()
        {
            // Creazione del prodotto tramite FactoryMethod
            IProduct product = FactoryMethod();
            product.Operation();
        }
    }

    // 5. ConcreteCreatorA: implementa FactoryMethod per ConcreteProductA
    public class ConcreteCreatorA : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    // 6. ConcreteCreatorB: implementa FactoryMethod per ConcreteProductB
    public class ConcreteCreatorB : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}