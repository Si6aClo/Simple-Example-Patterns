using System;
using System.Collections.Generic;
using System.Text;

namespace test_patterns
{
    class Subscriber
    {
        public void CallOperationsOn(Publisher publisher)
        {
            publisher.Operation();
        }
    }
}
