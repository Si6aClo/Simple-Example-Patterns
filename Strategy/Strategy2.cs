using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Strategy2 : IStrategy
    {
        public void Action()
        {
            Console.WriteLine("Strategy 2");
        }
    }
}
