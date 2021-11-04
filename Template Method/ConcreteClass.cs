using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method
{
    class ConcreteClass : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("PrimitiveOperation1");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("PrimitiveOperation2");
        }
    }
}
