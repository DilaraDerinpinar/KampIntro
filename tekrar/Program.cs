using System;

namespace tekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                customerNo = 1,
                FirstName = "dilara",
                LastName = "deniz"
            };

            Customer customer2 = new Customer();
            customer2.customerNo = 2;
            customer2.FirstName = "derya";
            customer2.LastName = "demiroğ";


            Customer customer3 = new Customer()
            {
                customerNo = 3,
                FirstName = "beren",
                LastName = "denden"
            };


            Customer[] customers = new Customer[3] { customer1, customer2, customer3 };

            foreach (var item in customers)
            {
                Console.WriteLine(item.FirstName);


            }
        }


        class Customer
        {
            public int customerNo { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }


    }
}
