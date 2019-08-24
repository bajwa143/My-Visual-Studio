using System;

namespace Inversion_of_Control_DI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructor Injection Test
            // By passing the services that implemented the IPrinable interface the builder assembled the dependencies
            ConstructorInjection cs = new ConstructorInjection(new ConstructorInjection.Person());
            cs.Printing();

            // Method Injection Test
            MethodInjection methodInjection = new MethodInjection();
            // Calling method and injecting dependency
            methodInjection.Printing(new MethodInjection.EventLogWriter());


            // Property Injection Test

            PropertyInjection property = new PropertyInjection();
            property.Printing();

            Console.WriteLine("------------------------------------------------------------");
            // For TutorialTeacher
            TutorialTeacher.ConstructorInjection constructorInjection =
                new TutorialTeacher.ConstructorInjection();

            TutorialTeacher.PropertyInjection propertyInjection =
                new TutorialTeacher.PropertyInjection();







            Console.Read();
        }
    }
}
