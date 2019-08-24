// In this sample class we are using factory to create object of CustomerDataAccess class
// We are actually reducing class coupling
namespace Inversion_of_Control_DI.TutorialTeacher
{
    class Customer
    {
        // CustomerDataAccess Class
        private class CustomerDataAccess : ICustomerDataAccess
        {
            public CustomerDataAccess()
            {
            }

            public string GetCustomerName(int id)
            {
                return "Dummy Customer Name";
            }
        }
        // End of CustomerDataAccess Class

        // Factory class to create CustomerDataAccess class objection
        public class DataAccessFactory
        {
            public static ICustomerDataAccess GetCustomerDataAccessObj()
            {
                return new CustomerDataAccess();
            }
        }

        // Business Logic class to implement business logic
        public class CustomerBusinessLogic
        {
            ICustomerDataAccess _custDataAccess;

            public CustomerBusinessLogic()
            {
                // using factory
                _custDataAccess = DataAccessFactory.GetCustomerDataAccessObj();
            }

            public string GetCustomerName(int id)
            {
                return _custDataAccess.GetCustomerName(id);
            }
        }
    }
}
