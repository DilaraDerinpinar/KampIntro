using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {

        public void AddCustomer(Customer[] customers, Customer customer5)
        {
            Console.WriteLine("******** ADD NEW CUSTOMER **********");
            Customer[] newCustomers = new Customer[5]; //diziye yeni bir eleman ekleyemeyiz kapasitesi belli ancak yeni dizi oluşturddum
            newCustomers[0] = customers[0];            //ekleme işlemini bu dizi içerisinde yaptım.
            newCustomers[1] = customers[1];
            newCustomers[2] = customers[2];
            newCustomers[3] = customers[3];
            newCustomers[4] = customer5;

            Console.WriteLine("****NEW CUSTOMER LIST****");
            foreach (var item in newCustomers)
            {
                Console.WriteLine($"Customers name: {item.username} ");
                Console.WriteLine($"Customers balance: {item.balance}");
                Console.WriteLine($"Customers id: {item.id}");
                Console.WriteLine($"Customers trade type: {item.trade_type}");
                Console.WriteLine(" ");
            }

        }


        public void ListOfCustomer(Customer[] customers)
        {
            Console.WriteLine("***** LIST OF CUSTOMERS *******");
            foreach (var item in customers)
            {
                Console.WriteLine($"Customers name: {item.username} ");
                Console.WriteLine($"Customers balance: {item.balance}");
                Console.WriteLine($"Customers id: {item.id}");
                Console.WriteLine($"Customers trade type: {item.trade_type}");
                Console.WriteLine(" ");
            }
        }

        public void RemoveCustomer(Customer[] customers)
        {
            Console.WriteLine("***** REMOVE CUSTOMER *****");
            Console.WriteLine("Silmek istediğiniz index numarasını giriniz (1, 2, 3, 4)");
            int result = Convert.ToInt32(Console.ReadLine());
            switch (result)
            {
                case 1:
                    customers[0].id = 0; //silinecek kişinin id si sıfırlanarak gösterilir.
                    break;
                case 2:
                    customers[1].id = 0;
                    break;
                case 3:
                    customers[2].id = 0;
                    break;
                case 4:
                    customers[3].id = 0;
                    break;
                default:
                    Console.WriteLine("Incorrect valid!!");
                    break;


            }
            Console.WriteLine("***** DELETION COMPLETED *********");
            foreach (var item in customers)
            {
                Console.WriteLine($"Customers name: {item.username} ");
                Console.WriteLine($"Customers balance: {item.balance}");
                Console.WriteLine($"Customers id: {item.id}");
                Console.WriteLine($"Customers trade type: {item.trade_type}");
                Console.WriteLine(" ");
            }
        }
    }
}
