using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Concrete;
using GameDemo.Entities;
using GameDemo.Concrete;
using GameDemo.ProjectServices;

namespace GameDemo.Concrete
{
    class UserValidationManager:IUserValidationService
    {
        public bool Validation(Customer customer)
        {
            if (customer.FirstName.Equals("John") && customer.LastName.Equals("Degree") && customer.Id == 1 && customer.Password.Equals("123456"))
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
