﻿using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;
using GameDemo.ProjectServices;

namespace GameDemo.Concrete
{
    class CustomerManager:ICustomerService
    {
        private IUserValidationService _userValidation;

        public CustomerManager(IUserValidationService userValidation)
        {
            _userValidation = userValidation;
        }
        public void SignUp(Customer customer)
        {

            if (_userValidation.Validation(customer) == true)
            {
                Console.WriteLine("Customer was added !");
            }
            else
            {
                Console.WriteLine($"Addition was completed! Welcome {customer.FirstName} {customer.LastName}");
            }
        }

        public void UpdateCustomer(Customer customer)
        {
            string firstname, lastname, password;
            int birthdate;
            Console.WriteLine("1.First Name \n 2.Last Name \n 3.Birthdate \n 4.Password ");
            Console.WriteLine("which information do you want to update?");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine("Enter your new First Name: ");
                    firstname = Convert.ToString(Console.ReadLine());
                    customer.FirstName = firstname;
                    Console.WriteLine("Your first name was updated! \n Your new first name is: {0}",customer.FirstName);
                    break;
                case 2:
                    Console.WriteLine("Enter your new Last Name");
                    lastname = Convert.ToString(Console.ReadLine());
                    customer.LastName = lastname;
                    Console.WriteLine("Your last name was updated! \n Your new last name is {0}",customer.LastName);
                    break;
                case 3:
                    Console.WriteLine("Enter your new date of birth");
                    birthdate = Convert.ToInt32(Console.ReadLine());
                    customer.Birthdate = birthdate;
                    Console.WriteLine("Your date of birth was updated! \n Your new date of birth is {0}",customer.Birthdate);
                    break;
                case 4:
                    Console.WriteLine("First, enter your old password");
                    password = Convert.ToString(Console.ReadLine());
                    if (customer.Password.Equals(password))
                    {
                        Console.WriteLine("Enter your new password");
                        password = Convert.ToString(Console.ReadLine());
                        customer.Password = password;
                        Console.WriteLine("Your password was updated! \n Your new password is {0}",customer.Password);
                    }
                    else
                    {
                        Console.WriteLine("Sorry ! password is incorrect which is your entered.");
                    }

                    break;
                default:
                    Console.WriteLine("Incorrect choose !!!");
                    break;
                        
            }
        }

        public void DeleteCustomer(Customer customer)
        {
            //burada da girilen kullanıcının kayıtlı olup olmadığını ve kayıtlıysa silinmesini sağlıyoruz:
            if (_userValidation.Validation(customer) == true)
            {
                Console.WriteLine($"{customer.FirstName} {customer.LastName} was deleted!");
            }
            else
            {
                Console.WriteLine("registered user not found");
            }
           
        }
    }
}
