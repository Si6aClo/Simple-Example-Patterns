using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Context
    {
        IStrategy strategy;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void DoAction()
        {
            strategy.Action();
        }
    }
}
