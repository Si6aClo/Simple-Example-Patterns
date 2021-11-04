using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class Proxy : Subject
    {
        RealSubject RealSubject;

        public override void Request()
        {
            if (RealSubject == null)
            {
                RealSubject = new RealSubject();
            }

            RealSubject.Request();
        }
    }
}
