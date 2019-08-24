using System;

namespace Inversion_of_Control_DI.TutorialTeacher
{
    // In the property injection, the dependency is provided through a public property
    class PropertyInjection
    {
        private class CustomerBusinessLogic
        {
            // Now using ICustomerDataAccess as property
            public ICustomerDataAccess DataAccess { get; set; }

            public string GetCustomerName(int id)
            {
                return DataAccess.GetCustomerName(id);
            }

            // Default constructor
            public CustomerBusinessLogic()
            {

            }


        }// End of CustomerBusinessLogic

        // CustomerDataAccess Class
        private class CustomerDataAccess : ICustomerDataAccess
        {
            public CustomerDataAccess()
            {
            }

            public string GetCustomerName(int id)
            {
                //get the customer name from the db in real application        
                return "Property Injection";
            }
        }
        // End of CustomerDataAccess Class


        // Start of CustomerService class
        public class CustomerService
        {
            CustomerBusinessLogic _customerBL;

            public CustomerService()
            {
                _customerBL = new CustomerBusinessLogic();
                // CustomerService class creates and sets CustomerDataAccess
                // class using this public property
                _customerBL.DataAccess = new CustomerDataAccess();
            }

            public string GetCustomerName(int id)
            {
                return _customerBL.GetCustomerName(id);
            }

        }// End of CustomerServiceClass


        public PropertyInjection()
        {
            CustomerService customerService =
            new CustomerService();

            string cName = customerService.GetCustomerName(3);
            Console.WriteLine(cName);
        }
    }
}
