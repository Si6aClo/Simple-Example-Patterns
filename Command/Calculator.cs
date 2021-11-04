using Command.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class Calculator
    {
        ArithmeticUnit ArithmeticUnit;
        ControlUnit ControlUnit;

        public Calculator()
        {
            ArithmeticUnit = new ArithmeticUnit();
            ControlUnit = new ControlUnit();
        }

        private int Run(Command command)
        {
            ControlUnit.StoreCommand(command);
            ControlUnit.ExecuteCommand();
            return ArithmeticUnit.Register;
        }

        public int Add(int operand)
        {
            return Run(new Add(ArithmeticUnit, operand));
        }

        public int Sub(int operand)
        {
            return Run(new Sub(ArithmeticUnit, operand));
        }

        public int Mul(int operand)
        {
            return Run(new Mul(ArithmeticUnit, operand));
        }

        public int Div(int operand)
        {
            return Run(new Div(ArithmeticUnit, operand));
        }

        public int Undo(int levels)
        {
            ControlUnit.Undo(levels);
            return ArithmeticUnit.Register;
        }

        public int Redo(int levels)
        {
            ControlUnit.Redo(levels);
            return ArithmeticUnit.Register;
        }
    }
}
