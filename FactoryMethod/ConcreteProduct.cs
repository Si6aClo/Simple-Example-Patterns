using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class ConcreteProduct : Product
    {
        public ConcreteProduct()
        {
            Console.WriteLine(this.GetHashCode());
        }
    }
}
