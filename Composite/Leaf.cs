using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {

        }

        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override Component GetChild(int index)
        {
            throw new NotImplementedException();
        }

        public override void Operation()
        {
            Console.WriteLine(name);
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
