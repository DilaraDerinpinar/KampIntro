using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.ManagementService;
using GameDemo.ProjectServices;

namespace GameDemo.ProjectManagementService
{
    class UserValidationManager:IUserValidationService
    {
        public bool Validation(Customer customer)
        {
            if (customer.firstName.Equals("John") && customer.lastName.Equals("Degree") && customer.id == 1 && customer.password.Equals("123456"))
            {
                return true;
            }
            else
            {
                return false;
                
            }
        }

        internal bool Validation(CustomerManager customerManager)
        {
            throw new NotImplementedException();
        }
    }
}
