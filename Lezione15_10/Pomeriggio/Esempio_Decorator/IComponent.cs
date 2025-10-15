using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione15_10.Pomeriggio.Esempio_Decorator
{
    public interface IComponentES
    {
        void Operation();
    }

    // 2. ConcreteComponent: oggetto base senza decorazioni
    public class ConcreteComponent : IComponentES
    {
        public void Operation()
        {
            Console.WriteLine("ConcreteComponent: operazione di base");
        }
    }

    // 3. Decorator: classe astratta che implementa IComponent
    //    e incapsula un IComponent interno
    public abstract class Decorator : IComponentES
    {
        // Riferimento al componente "decorato"
        protected IComponentES _component;

        // Costruttore: richiede un componente da decorare
        protected Decorator(IComponentES component)
        {
            _component = component;
        }

        // Delegazione dell'operazione al componente interno
        public virtual void Operation()
        {
            _component.Operation();
        }
    }

    // 4. ConcreteDecoratorA: aggiunge comportamento prima e dopo la chiamata
    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(IComponentES component)
            : base(component) { }

        public override void Operation()
        {
            Console.WriteLine("ConcreteDecoratorA: pre‑operazione");
            base.Operation();  // chiama Operation() sul componente interno
            Console.WriteLine("ConcreteDecoratorA: post‑operazione");
        }
    }

    // 5. ConcreteDecoratorB: aggiunge un altro comportamento distinto
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(IComponentES component)
            : base(component) { }

        public override void Operation()
        {
            Console.WriteLine("ConcreteDecoratorB: aggiunta funzionalità prima");
            base.Operation();
        }
    }
}