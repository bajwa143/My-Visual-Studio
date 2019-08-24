using System;

namespace Inversion_of_Control_DI
{
    class ConstructorInjection
    {
        private IPrintable _print;
        // The constructor injection normally has only one parameterized constructor, 
        // so in this constructor dependency there is no default constructor and we need 
        // to pass the specified value at the time of object creation.
        public ConstructorInjection(IPrintable printable)
        {
            _print = printable;
        }

        public void Printing()
        {
            // We can use the injection component anywhere within the class
            _print.Print();
        }

        // Inner Person class
        public class Person : IPrintable
        {
            public void Print()
            {
                Console.WriteLine("I am in print of Constructor Injection");
                Console.WriteLine("Printing Person detail...");
            }
        }
    }

}
