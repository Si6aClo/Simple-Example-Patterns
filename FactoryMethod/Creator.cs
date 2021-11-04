using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    abstract class Creator
    {
        Product product;

        public abstract Product FactoryMethod();

        public void AnOperation()
        {
            product = FactoryMethod();
        }
    }
}
