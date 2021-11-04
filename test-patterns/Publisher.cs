using System;
using System.Collections.Generic;
using System.Text;

namespace test_patterns
{
    class Publisher
    {
        public void SendMessageto(Subscriber subscriber)
        {
            subscriber.CallOperationsOn(this);
        }

        public void Operation()
        {
            Console.WriteLine("Выполнена операция");
        }
    }
}
