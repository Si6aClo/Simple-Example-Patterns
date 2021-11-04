using System;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = new ConcreteClass();
            instance.TemplateMethod();
        }
    }
}
