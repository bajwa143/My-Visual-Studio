using System;

namespace Inversion_of_Control_DI
{
    class MethodInjection
    {
        IPrintable printable = null;

        // In method injection we need to pass the dependency in the method only
        public void Printing(IPrintable printable)
        {
            this.printable = printable;
            printable.Print();
        }

        // Inner EventLogWriter class
        public class EventLogWriter : IPrintable
        {
            public void Print()
            {
                Console.WriteLine("I am in print of Method Injection");
                Console.WriteLine("Printing log...");

            }

        }
    }
}
