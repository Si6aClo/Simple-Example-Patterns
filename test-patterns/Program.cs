using System;

namespace test_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            publisher.SendMessageto(subscriber);
        }
    }
}
