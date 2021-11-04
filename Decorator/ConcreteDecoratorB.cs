using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class ConcreteDecoratorB : Decorator
    {
        void AddedBehavior()
        {
            Console.WriteLine("Behavior");
        }

        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
        }
    }
}
