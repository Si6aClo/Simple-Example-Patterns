using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Strategy1 : IStrategy
    {
        public void Action()
        {
            Console.WriteLine("Strategy 1");
        }
    }
}
