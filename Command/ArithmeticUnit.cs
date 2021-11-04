using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{   
    // Receiver(Получатель)
    class ArithmeticUnit
    {
        public int Register { get; private set; }

        public void Run(char operationCode, int operand)
        {
            switch (operationCode)
            {
                case '+':
                    Register += operand;
                    break;
                case '-':
                    Register -= operand;
                    break;
                case '*':
                    Register *= operand;
                    break;
                case '/':
                    Register /= operand;
                    break;
            }
        }
    }
}
