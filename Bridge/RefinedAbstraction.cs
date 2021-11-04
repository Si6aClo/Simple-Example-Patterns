using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(Implementor imp) : base(imp)
        {

        }

        public override void Operation()
        {
            base.Operation();
        }
    }
}
