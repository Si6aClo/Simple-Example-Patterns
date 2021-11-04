using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Component component = new ConcreteComponent();
            var decoratorA = new ConcreteDecoratorA();
            var decoratorB = new ConcreteDecoratorB();

            decoratorA.Component = component;
            decoratorB.Component = decoratorA;
            decoratorB.Operation();
        }
    }
}
