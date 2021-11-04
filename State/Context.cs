using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Context
    {
        public State state { get; set; }

        public Context(State state)
        {
            this.state = state;
        }

        public void Request()
        {
            this.state.Handle(this);
        }
    }
}
