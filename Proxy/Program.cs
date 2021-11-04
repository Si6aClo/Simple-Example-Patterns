using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Proxy();
            subject.Request();
        }
    }
}
