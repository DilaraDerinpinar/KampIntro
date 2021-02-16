using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.ProjectServices
{
    interface ICustomerService
    {
        void SignUp(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);

    }
}
