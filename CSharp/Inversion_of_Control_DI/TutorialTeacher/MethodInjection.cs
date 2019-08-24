using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversion_of_Control_DI.TutorialTeacher
{
    class MethodInjection
    {
    }
/*
    // Yet to implement
    interface IDataAccessDependency
    {
        void SetDependency(ICustomerDataAccess customerDataAccess);
    }

    public class CustomerBusinessLogic : IDataAccessDependency
    {
        ICustomerDataAccess _dataAccess;

        public CustomerBusinessLogic()
        {
        }

        public string GetCustomerName(int id)
        {
            return _dataAccess.GetCustomerName(id);
        }

        public void SetDependency(ICustomerDataAccess customerDataAccess)
        {
            _dataAccess = customerDataAccess;
        }
    }

    public class CustomerService
    {
        CustomerBusinessLogic _customerBL;

        public CustomerService()
        {
            _customerBL = new CustomerBusinessLogic();
            ((IDataAccessDependency)_customerBL).SetDependency(new CustomerDataAccess());
        }

        public string GetCustomerName(int id)
        {
            return _customerBL.GetCustomerName(id);
        }
    }*/
}
