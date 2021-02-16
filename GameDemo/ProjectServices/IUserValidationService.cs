using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.ProjectServices
{
    interface IUserValidationService
    {
        bool Validation(Customer customer);
    }
}
