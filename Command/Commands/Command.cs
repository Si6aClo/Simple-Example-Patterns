using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    abstract class Command
    {
        protected ArithmeticUnit unit;
        protected int operand;

        public abstract void Execute();
        public abstract void UnExecute();
    }
}
