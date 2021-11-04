﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Commands
{
    class Div : Command
    {
        public Div(ArithmeticUnit unit, int operand)
        {
            this.unit = unit;
            this.operand = operand;
        }

        public override void Execute()
        {
            unit.Run('/', operand);
        }

        public override void UnExecute()
        {
            unit.Run('*', operand);
        }
    }
}
