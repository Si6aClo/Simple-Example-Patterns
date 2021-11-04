using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Adapter : Adaptee, ITarget
    {
        public void Request()
        {
            SpecificRequest();
        }
    }
}
