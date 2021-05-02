using System;

namespace ClassMetotDemo
{
    class Program
    {
        //3.hafta ödevi
        static void Main(string[] args)
        {
            //verileri tanımlayalım: 

            Customer customer1 = new Customer()
            {
                username = "ece taştan",
                id = 1,
                balance = 5000.45,
                trade_type = "withdraw money"
            };

            Customer customer2 = new Customer()
            {
                username = "bekir ocak",
                id = 2,
                balance = 10000.0,
                trade_type = "transferred money"
            };

            Customer customer3 = new Customer()
            {
                username = "atilla kaya",
                id = 3,
                balance = 7000.300,
                trade_type = "deposit money"
            };

            Customer customer4 = new Customer()
            {
                username = "ezgi çınar",
                id = 4,
                balance = 9000.900,
                trade_type = "withdraw money"
            };

            Customer customer5 = new Customer()
            {
                username = "beril kökbay",
                id = 5,
                balance = 6000.0,
                trade_type = "deposit money"
            };

            //bu verileri customers dizisine atadım:
            Customer[] customers = new Customer[4] { customer1, customer2, customer3, customer4 };

            CustomerManager customerManager = new CustomerManager();

            customerManager.AddCustomer(customers,customer5);

            customerManager.ListOfCustomer(customers); //listeleme işlemi

            customerManager.RemoveCustomer(customers); //silme işlemi

            Console.ReadLine();
        }
    }
}
