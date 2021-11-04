using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context;
            context = new Context(new Strategy1());
            context.DoAction();

            context = new Context(new Strategy2());
            context.DoAction();
        }
    }
}
