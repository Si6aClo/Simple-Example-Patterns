using System;
using System.Collections.Generic;
using System.Text;

namespace CommandSimple
{
    abstract class Command
    {
        protected Receiver receiver;

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Execute();
    }
}
