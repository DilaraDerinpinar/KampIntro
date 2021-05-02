using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.ProjectServices
{ 
    interface IUserValidationService
    {
        bool Validation(Customer customer);
    }
}
