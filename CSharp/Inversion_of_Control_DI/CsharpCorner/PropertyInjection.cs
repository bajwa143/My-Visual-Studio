using System;

namespace Inversion_of_Control_DI
{
    // We use constructor injection, but there are some cases where 
    // we need a parameter-less constructor so we need to use property injection
    class PropertyInjection
    {
        private IPrintable Printable { get; set; }
        public PropertyInjection()
        {
            Printable = new Person();
        }
        public void Printing()
        {
            Printable.Print();
        }

        // Inner Person class
        private class Person : IPrintable
        {
            public void Print()
            {
                Console.WriteLine("I am in print of Property Injection");
                Console.WriteLine("Printing Person detail...");
            }
        }
    }
}
