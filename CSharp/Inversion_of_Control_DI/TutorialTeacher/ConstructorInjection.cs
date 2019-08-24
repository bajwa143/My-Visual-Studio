using System;

namespace Inversion_of_Control_DI.TutorialTeacher
{
    class ConstructorInjection
    {

        // Business Logic class to implement business logic
        public class CustomerBusinessLogic
        {
            ICustomerDataAccess _custDataAccess;


            public CustomerBusinessLogic(ICustomerDataAccess custDataAccess)
            {
                // using Constructor to create object of ICustomerDataAccess
                _custDataAccess = custDataAccess;
            }

            // Default constructor
            public CustomerBusinessLogic()
            {
                _custDataAccess = new CustomerDataAccess();
            }

            public string GetCustomerName(int id)
            {
                return _custDataAccess.GetCustomerName(id);
            }
        }      //End of CustomerBusinessLogic


        // CustomerDataAccess Class
        private class CustomerDataAccess : ICustomerDataAccess
        {
            public CustomerDataAccess()
            {
            }

            public string GetCustomerName(int id)
            {
                //get the customer name from the db in real application        
                return "Constructor Injection";
            }
        }
        // End of CustomerDataAccess Class


        public ConstructorInjection()
        {
            CustomerBusinessLogic constructorInjection =
            new CustomerBusinessLogic();

            string cName = constructorInjection.GetCustomerName(3);
            Console.WriteLine(cName);
        }
    }
}